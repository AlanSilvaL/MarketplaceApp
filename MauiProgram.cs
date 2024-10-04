using CommunityToolkit.Maui;
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
                .UseMauiCommunityToolkit()
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
            RegisterRoutes();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();


        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<IApiClientService, ApiClientService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            return builder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<DetailPageViewModel>();
            return builder;
        }


        public static MauiAppBuilder RegisterViews( this MauiAppBuilder builder) 
        {
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<CartPage>();
            return builder;
        }

        public static void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        }

    }
}
