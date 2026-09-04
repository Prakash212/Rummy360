using Rummy360.Views;

namespace Rummy360;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(PlayersPage), typeof(PlayersPage));
        Routing.RegisterRoute(nameof(AddPlayerPage), typeof(AddPlayerPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(NewGamePage), typeof(NewGamePage));
        Routing.RegisterRoute(nameof(LiveScorePage), typeof(LiveScorePage));
        Routing.RegisterRoute(nameof(RoundCompletedPage), typeof(RoundCompletedPage));
        Routing.RegisterRoute(nameof(RoundEntryPage), typeof(RoundEntryPage));
        Routing.RegisterRoute(nameof(RoundHistoryPage), typeof(RoundHistoryPage));
        Routing.RegisterRoute(nameof(SeatingOrderPage), typeof(SeatingOrderPage));
        Routing.RegisterRoute(nameof(SelectPlayersPage), typeof(SelectPlayersPage));
        Routing.RegisterRoute(nameof(StatisticsPage), typeof(StatisticsPage));
    }
}
