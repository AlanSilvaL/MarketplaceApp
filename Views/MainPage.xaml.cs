namespace MarketplaceApp.Views;
using MarketplaceApp.ViewModel;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
