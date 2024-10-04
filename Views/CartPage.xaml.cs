namespace MarketplaceApp.Views;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetTabBarIsVisible(this, false);
    }
}