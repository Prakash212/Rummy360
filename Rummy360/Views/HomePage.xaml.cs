using Rummy360.Views.Base;

namespace Rummy360.Views;

public partial class HomePage : BasePage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void PlayersCard_Tapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PlayersPage));
    }
    private async void NewGame_Tapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewGamePage));
    }
    private async void Statistics_Tapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StatisticsPage));
    }
    private async void Settings_Tapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }
}