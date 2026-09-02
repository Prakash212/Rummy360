namespace Rummy360.Views;

public partial class NewGamePage : ContentPage
{
	public NewGamePage()
	{
		InitializeComponent();
	}
    private async void StartGame_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SelectPlayersPage));
    }
}