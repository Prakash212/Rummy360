using Rummy360.Views.Base;

namespace Rummy360.Views;

public partial class SplashPage : BasePage
{
    public SplashPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Cards appear one after another
        await AnimateCard(SpadeCard);
        await AnimateCard(HeartCard);
        await AnimateCard(DiamondCard);
        await AnimateCard(ClubCard);

        // Crown appears after cards
        await AnimateCrown();

        // Logo ring
        await LogoRing.FadeToAsync(1, 250);
        await LogoRing.ScaleToAsync(1.08, 300);

        // Logo text
        await LogoText.FadeToAsync(1, 250);
        await LogoText.TranslateToAsync(0, 0, 200);

        await Task.Delay(1000);
        await Shell.Current.GoToAsync(nameof(HomePage));
    }

    private static async Task AnimateCard(Image card)
    {
        await card.FadeToAsync(1, 180);
        await card.ScaleToAsync(1, 220, Easing.CubicOut);
    }

    private async Task AnimateCrown()
    {
        // Always reset starting position
        CrownImage.Opacity = 0;
        CrownImage.TranslationY = -20;
        CrownImage.Scale = 1.5;

        // Fade while dropping to the final position
        var fade = CrownImage.FadeToAsync(1, 180);
        var drop = CrownImage.TranslateToAsync(0, 30, 280, Easing.CubicOut);

        await Task.WhenAll(fade, drop);

        // Small landing bounce
        await CrownImage.TranslateToAsync(0, 24, 90, Easing.CubicInOut);
        await CrownImage.TranslateToAsync(0, 30, 120, Easing.BounceOut);
    }
}