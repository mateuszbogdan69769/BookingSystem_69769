using Domain.Aggregates.ReservationServices;
using Domain.Aggregates.StatisticsServices;
using Domain.Roots.Accounts.Services;
using Domain.Roots.Bookings.Services;
using Domain.Roots.Guests.Services;

namespace BookingSystem_69769
{
    public partial class RegisterForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IGuestService _guestService;
        private readonly IBookingService _bookingService;
        private readonly IReservationService _reservationService;
        private readonly IStatisticService _statisticService;

        public RegisterForm(IAccountService accountService, IGuestService guestService, IBookingService bookingService, IReservationService reservationService, IStatisticService statisticService)
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

        private void register_login_btn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_accountService, _guestService, _bookingService, _reservationService, _statisticService);
            loginForm.Show();
            Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private async void register_btn_Click(object sender, EventArgs e)
        {
            var (nameSurname, username, password) = (register_nameSurname.Text, register_username.Text, register_password.Text);

            if (String.IsNullOrEmpty(nameSurname))
            {
                MessageBox.Show("Imię i nazwisko jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nazwa użytkownika jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hasło jest wymagane.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usernameTaken = (await _accountService.GetAccountByUsername(username)) is not null;
            if (usernameTaken)
            {
                MessageBox.Show($"Użytkownik \"{username}\" już istnieje.", "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _accountService.AddAccount(nameSurname, username, password);

            MessageBox.Show("Zarejestrowano pomyślnie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var loginForm = new LoginForm(_accountService, _guestService, _bookingService, _reservationService, _statisticService);
            loginForm.Show();
            Hide();
        }
    }
}
