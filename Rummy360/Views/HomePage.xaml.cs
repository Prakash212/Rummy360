namespace Rummy360.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void PlayersCard_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PlayersPage));
    }
    private async void NewGame_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewGamePage));
    }
}