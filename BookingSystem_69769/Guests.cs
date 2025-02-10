using Domain.Roots.Guests;
using Domain.Roots.Guests.Services;

namespace BookingSystem_69769
{
    public partial class Guests : UserControl
    {
        private readonly IGuestService _guestService;

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public Guests(IGuestService guestService)
        {
            _guestService = guestService;

            InitializeComponent();

            guests_table.AutoGenerateColumns = false;
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guests_table.Columns[e.ColumnIndex].Name == "guest_deletecolumn")
            {
                var result = MessageBox.Show("Czy na pewno chcesz usunąć gościa i jego rezerwacje?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                var selectedGuest = guests_table.CurrentRow.DataBoundItem as Guest;
                if (selectedGuest is null) return;
                await _guestService.DeleteGuestById(selectedGuest.Id);
                await LoadGuests();
            }
        }

        public async Task LoadGuests()
        {
            await _semaphore.WaitAsync();

            try
            {
                guests_table.DataSource = await _guestService.GetFilteredGuests(guest_searchfield.Text, includeBookings: true);

                guests_table.CellFormatting += guests_table_CellFormatting;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private void guests_table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guests_table.Columns[e.ColumnIndex].Name == "bookingsCount" && e.Value is IEnumerable<object> enumerableValue)
            {
                e.Value = enumerableValue.Cast<object>().Count().ToString();
            }
        }

        private async void guests_add_btn_Click(object sender, EventArgs e)
        {
            var (name, surname) = (guests_name.Text, guests_surname.Text);

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Imię gościa jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Nazwisko gościa jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newGuest = new Guest(name, surname);
            await _guestService.AddGuest(newGuest);
            await LoadGuests();

            ClearFields();
        }

        private void ClearFields()
        {
            guests_name.Clear();
            guests_surname.Clear();
        }

        private async void guest_searchfield_TextChanged(object sender, EventArgs e)
        {
            await LoadGuests();
        }

        public void ResetFilters()
        {
            guest_searchfield.Clear();
        }
    }
}
