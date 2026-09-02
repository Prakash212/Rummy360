namespace Rummy360.Views;

public partial class SeatingOrderPage : ContentPage
{
	public SeatingOrderPage()
	{
		InitializeComponent();
	}
    private async void StartRound_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LiveScorePage));
    }
}