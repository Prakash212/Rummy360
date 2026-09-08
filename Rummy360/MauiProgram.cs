using Microsoft.Extensions.Logging;
using Rummy360.Services;
using Rummy360.Views;
using Microsoft.Maui.Handlers;

#if ANDROID
using Color = Android.Graphics.Color;
using Android.Content.Res;
using Android.Graphics;
#endif

namespace Rummy360
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<PlayerService>();

            // Remove Android Entry underline globally
            EntryHandler.Mapper.AppendToMapping("BorderlessEntry", (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.BackgroundTintList =
                    ColorStateList.ValueOf(Color.Transparent);

                handler.PlatformView.SetBackgroundColor(Color.Transparent);
#endif
            });

            return builder.Build();
        }
    }
}
