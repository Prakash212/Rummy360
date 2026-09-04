using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Views;
using System.Runtime.Versioning;

namespace Rummy360
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        [SupportedOSPlatform("android21.0")]
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var window = Window;
            if (window == null)
                return;

#pragma warning disable CA1416
#pragma warning disable CS0618

            // Brand Purple Status Bar
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
#pragma warning disable CA1422
                window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#2E0A9E"));
#pragma warning restore CA1422
            }

            // White icons on Android 11+ (API 30+)
            if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
            {
                window.InsetsController?.SetSystemBarsAppearance(
                    0,
                    (int)WindowInsetsControllerAppearance.LightStatusBars);
            }
            else
            {
                window.DecorView.SystemUiVisibility = 0;
            }

#pragma warning restore CS0618
#pragma warning restore CA1416
        }
    }
}
