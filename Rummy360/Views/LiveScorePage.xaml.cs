namespace Rummy360.Views;

public partial class LiveScorePage : ContentPage
{
	public LiveScorePage()
	{
		InitializeComponent();
	}
    private async void AddRound_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RoundEntryPage));
    }
}