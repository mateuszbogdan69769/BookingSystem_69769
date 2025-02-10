using Domain.Aggregates.ReservationServices;
using Domain.Aggregates.ReservationServices.Models;
using Domain.Roots.Bookings;
using Domain.Roots.Bookings.Services;
using Domain.Roots.Guests;

namespace BookingSystem_69769
{
    public partial class Reservations : UserControl
    {
        private readonly IReservationService _reservationService;
        private readonly IBookingService _bookingService;
        private int _clickedBookingId;

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public Reservations(IReservationService reservationService, IBookingService bookingService)
        {
            _reservationService = reservationService;
            _bookingService = bookingService;

            InitializeComponent();
            reservations_table.AutoGenerateColumns = false;
        }

        public void ResetFilters()
        {
            reservations_searchquery.Clear();
            reservations_datefrom_search.Value = new DateTime(DateTime.Now.Year, 1, 1);
            reservations_dateto_search.Value = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59, 999);
        }

        public async Task LoadBookings()
        {
            await _semaphore.WaitAsync();
            try
            {
                reservations_table.DataSource = new List<Booking>();
                var (searchQuery, dateFrom, dateTo) = (reservations_searchquery.Text, reservations_datefrom_search.Value, reservations_dateto_search.Value);
                reservations_table.DataSource = await _bookingService.GetFilteredBookings(searchQuery, dateFrom.ToUniversalTime(), dateTo.ToUniversalTime());

                reservations_table.CellFormatting += reservations_table_CellFormatting;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private void reservations_table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (reservations_table.Columns[e.ColumnIndex].Name == "date" && e.Value is DateTime startDate)
            {
                var localDate = startDate.ToLocalTime();
                e.Value = $"{AddZeroIfShortText(localDate.Day)}-{AddZeroIfShortText(localDate.Month)}-{localDate.Year}";
            }
            if (reservations_table.Columns[e.ColumnIndex].Name == "startTime" && e.Value is DateTime startTime)
            {
                var localDate = startTime.ToLocalTime();
                e.Value = $"{AddZeroIfShortText(localDate.Hour)}:{AddZeroIfShortText(localDate.Minute)}";
            }
            if (reservations_table.Columns[e.ColumnIndex].Name == "endTime" && e.Value is DateTime endTime)
            {
                var localDate = endTime.ToLocalTime();
                e.Value = $"{AddZeroIfShortText(localDate.Hour)}:{AddZeroIfShortText(localDate.Minute)}";
            }
            if (reservations_table.Columns[e.ColumnIndex].Name == "guest" && e.Value is Guest guest)
            {
                e.Value = $"{guest.Name} {guest.Surname}";
            }
        }

        private string AddZeroIfShortText(int number)
        {
            var text = number.ToString();
            if (text.Length == 1)
            {
                return $"0{text}";
            }
            return text;
        }

        private async void reservations_add_btn_Click(object sender, EventArgs e)
        {
            var (guestName, guestSurname) = (reservations_guest_name.Text, reservations_guest_surname.Text);
            var (date, timeFrom, timeTo) = (reservations_date.Value, reservations_timefrom.Text, reservations_timeto.Text);
            var (partySize, note) = (reservations_partysize.Text, reservations_note.Text);


            if (String.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Imię gościa jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(guestSurname))
            {
                MessageBox.Show("Nazwisko gościa jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TimeOnly.TryParse(timeFrom, out var timeOnlyFrom))
            {
                MessageBox.Show("Niepoprawny format czasu startu rezerwacji.", "Niepoprawne dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!TimeOnly.TryParse(timeTo, out var timeToFrom))
            {
                MessageBox.Show("Niepoprawny format czasu końca rezerwacji.", "Niepoprawne dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(partySize.Trim(), out var partySizeNumber))
            {
                MessageBox.Show("Liczba gości musi być liczbą.", "Niepoprawne dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var guestConfig = new GuestConfig()
            {
                Name = guestName,
                Surname = guestSurname
            };

            var dateOnlyDate = DateOnly.FromDateTime(date);

            var bookingConfig = new BookingConfig()
            {
                StartDate = dateOnlyDate.ToDateTime(timeOnlyFrom).ToUniversalTime(),
                EndDate = dateOnlyDate.ToDateTime(timeToFrom).ToUniversalTime(),
                PartySize = partySizeNumber,
                Note = note
            };

            await _reservationService.CreateNewBooking(guestConfig, bookingConfig);
            await LoadBookings();

            ClearFields();
        }

        private void ClearFields()
        {
            reservations_guest_name.Clear();
            reservations_guest_surname.Clear();
            reservations_date.Value = DateTime.Now;
            reservations_timefrom.Clear();
            reservations_timeto.Clear();
            reservations_partysize.Clear();
            reservations_note.Clear();
        }

        private async void reservations_searchquery_TextChanged(object sender, EventArgs e)
        {
            await LoadBookings();
        }

        private async void reservations_datefrom_search_ValueChanged(object sender, EventArgs e)
        {
            await LoadBookings();
        }

        private async void reservations_dateto_search_ValueChanged(object sender, EventArgs e)
        {
            await LoadBookings();
        }

        private async void reservations_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedReservation = reservations_table.CurrentRow.DataBoundItem as Booking;
            if (selectedReservation is null) return;

            if (reservations_table.Columns[e.ColumnIndex].Name == "reservations_deletecolumn")
            {
                var result = MessageBox.Show("Czy na pewno chcesz usunąć rezerwacje?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                await _bookingService.DeleteReservationById(selectedReservation.Id);
                await LoadBookings();
                return;
            }

            var startDate = selectedReservation.StartDate;
            var endDate = selectedReservation.EndDate;

            _clickedBookingId = selectedReservation.Id;
            reservations_guest_name.Text = selectedReservation.Guest.Name;
            reservations_guest_surname.Text = selectedReservation.Guest.Surname;
            reservations_date.Value = startDate;
            reservations_timefrom.Text = $"{startDate.Hour}:{startDate.Minute}";
            reservations_timeto.Text = $"{endDate.Hour}:{endDate.Minute}";
            reservations_partysize.Text = selectedReservation.PartySize.ToString();
            reservations_note.Text = selectedReservation.Note;
        }
    }
}
