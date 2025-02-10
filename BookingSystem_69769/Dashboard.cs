using Domain.Aggregates.StatisticsServices;

namespace BookingSystem_69769
{
    public partial class Dashboard : UserControl
    {
        private readonly IStatisticService _statisticService;

        public Dashboard(IStatisticService statisticService)
        {
            _statisticService = statisticService;

            InitializeComponent();
        }

        public async Task LoadStats()
        {
            var stats = await _statisticService.GetStats();

            dashboard_totalbookings.Text = stats.TotalBookings.ToString();
            dashboard_totalguests.Text = stats.TotalGuests.ToString();
            dashboard_bookingstoday.Text = stats.BookingsToday.ToString();
            dashboard_peoplestoday.Text = stats.PeoplesToday.ToString();
        }
    }
}
