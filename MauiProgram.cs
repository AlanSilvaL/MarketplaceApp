using MarketplaceApp.Services;
using MarketplaceApp.ViewModel;
using MarketplaceApp.Views;
using Microsoft.Extensions.Logging;

namespace MarketplaceApp
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
                    fonts.AddFont("fa-light-300.ttf", "FALight");
                    fonts.AddFont("fa-regular-400.ttf", "FARegular");
                    fonts.AddFont("fa-solid-900.ttf", "FASolid");
                })
                .RegisterServices()
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();


        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<IApiClientService, ApiClientService>();
            return builder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<MainPageViewModel>();
            return builder;
        }


        public static MauiAppBuilder RegisterViews( this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<MainPage>();
            return builder;
        }

    }
}
