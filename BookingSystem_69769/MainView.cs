using Domain.Aggregates.ReservationServices;
using Domain.Aggregates.StatisticsServices;
using Domain.Roots.Accounts.Services;
using Domain.Roots.Bookings.Services;
using Domain.Roots.Guests.Services;

namespace BookingSystem_69769
{
    public partial class MainView : Form
    {
        private readonly IAccountService _accountService;
        private readonly IGuestService _guestService;
        private readonly IBookingService _bookingService;
        private readonly IReservationService _reservationService;
        private readonly IStatisticService _statisticService;

        public MainView(IAccountService accountService, IGuestService guestService, IBookingService bookingService, IReservationService reservationService, IStatisticService statisticService)
        {
            _accountService = accountService;
            _guestService = guestService;
            _reservationService = reservationService;
            _bookingService = bookingService;
            _statisticService = statisticService;

            InitializeComponent();

            guests_view = new Guests(_guestService);
            reservations_view = new Reservations(_reservationService, _bookingService);
            dashboard_view = new Dashboard(_statisticService);

            panel3.Controls.Add(reservations_view);
            panel3.Controls.Add(dashboard_view);
            panel3.Controls.Add(guests_view);

            var globalStore = GlobalStore.GetInstance();
            welcome_text.Text = $"Witaj, {globalStore.Username}";

            reservations_view.LoadBookings();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            var loginForm = new LoginForm(_accountService, _guestService, _bookingService, _reservationService, _statisticService);
            loginForm.Show();
            Hide();
        }

        private async void dashboard_btn_Click(object sender, EventArgs e)
        {
            await dashboard_view.LoadStats();

            dashboard_view.Visible = true;
            reservations_view.Visible = false;
            guests_view.Visible = false;
        }

        private async void reservations_btn_Click(object sender, EventArgs e)
        {
            reservations_view.ResetFilters();
            await reservations_view.LoadBookings();

            dashboard_view.Visible = false;
            reservations_view.Visible = true;
            guests_view.Visible = false;
        }

        private async void guests_btn_Click(object sender, EventArgs e)
        {
            guests_view.ResetFilters();
            await guests_view.LoadGuests();

            dashboard_view.Visible = false;
            reservations_view.Visible = false;
            guests_view.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
