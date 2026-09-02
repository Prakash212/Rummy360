namespace Rummy360.Views;

public partial class RoundEntryPage : ContentPage
{
	public RoundEntryPage()
	{
		InitializeComponent();
	}
    private async void SaveRound_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RoundCompletedPage));
    }
}