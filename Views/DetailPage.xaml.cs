using MarketplaceApp.ViewModel;
using MarketplaceApp.Model;

namespace MarketplaceApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetTabBarIsVisible(this, false);
    }
}