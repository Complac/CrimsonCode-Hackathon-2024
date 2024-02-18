using MauiHackathon.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiHackathon
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
                    fonts.AddFont("ProzaLibre-Regular.ttf", "ProzaLibre");
                    fonts.AddFont("YsabeauInfant-Regular.ttf", "YsabeauInfant");
                    fonts.AddFont("VarelaRound-Regular.ttf", "VarelaRound");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<FlashcardsPage>();
            builder.Services.AddTransient<FlashcardsViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
