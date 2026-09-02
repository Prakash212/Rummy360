namespace Rummy360.Views;

public partial class SelectPlayersPage : ContentPage
{
	public SelectPlayersPage()
	{
		InitializeComponent();
	}
    private async void Continue_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SeatingOrderPage));
    }
}