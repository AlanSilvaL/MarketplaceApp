using MarketplaceApp.ViewModel;
namespace MarketplaceApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        NavigationPage.SetHasNavigationBar(this, false);
    }
}
