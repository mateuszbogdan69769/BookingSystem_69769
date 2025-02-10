using Domain.Aggregates.ReservationServices;
using Domain.Aggregates.StatisticsServices;
using Domain.Roots.Accounts.Services;
using Domain.Roots.Bookings.Services;
using Domain.Roots.Guests.Services;

namespace BookingSystem_69769
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IGuestService _guestService;
        private readonly IBookingService _bookingService;
        private readonly IReservationService _reservationService;
        private readonly IStatisticService _statisticService;

        public LoginForm(IAccountService accountService, IGuestService guestService, IBookingService bookingService, IReservationService reservationService, IStatisticService statisticService)
        {
            _accountService = accountService;
            _guestService = guestService;
            _bookingService = bookingService;
            _reservationService = reservationService;
            _statisticService = statisticService;

            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_register_btn_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_accountService, _guestService, _bookingService, _reservationService, _statisticService);
            registerForm.Show();
            Hide();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            var (username, password) = (login_username.Text, login_password.Text);

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nazwa u¿ytkownika jest wymagana.", "Brakuj¹ce dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Has³o jest wymagane.", "Brakuj¹ce dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loginSuccess = await _accountService.Login(username, password);
            if (!loginSuccess)
            {
                MessageBox.Show("Niepoprawna nazwa u¿ytkownika lub has³o.", "Wyst¹pi³ b³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var globalStore = GlobalStore.GetInstance();
            globalStore.SetUsername(username);

            var mainView = new MainView(_accountService, _guestService, _bookingService, _reservationService, _statisticService);
            mainView.Show();
            Hide();
        }
    }
}
