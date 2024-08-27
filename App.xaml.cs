using MarketplaceApp.ViewModel;
using MarketplaceApp.Views;

namespace MarketplaceApp;



//public partial class App : Application
//{
//    public App(MainPageViewModel mainPageViewModel)
//    {
//        InitializeComponent();

//        MainPage = new MainPage(mainPageViewModel);
//    }
//}


public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}