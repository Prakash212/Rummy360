namespace Rummy360.Views;

public partial class RoundCompletedPage : ContentPage
{
	public RoundCompletedPage()
	{
		InitializeComponent();
	}
    private async void History_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RoundHistoryPage));
    }
}