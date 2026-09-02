namespace Rummy360.Views;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
		InitializeComponent();		
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Show splash for 2 seconds
        await Task.Delay(2000);

        // Navigate to HomePage (Correct for .NET 10 MAUI)
        await Shell.Current.GoToAsync(nameof(HomePage));        
    }
}