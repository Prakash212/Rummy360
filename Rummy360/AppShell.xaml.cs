using Rummy360.Views;

namespace Rummy360;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        //Routing.RegisterRoute(nameof(SplashPage), typeof(SplashPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(PlayersPage), typeof(PlayersPage));
        Routing.RegisterRoute(nameof(NewGamePage), typeof(NewGamePage));
        Routing.RegisterRoute(nameof(SelectPlayersPage), typeof(SelectPlayersPage));
    }
}
