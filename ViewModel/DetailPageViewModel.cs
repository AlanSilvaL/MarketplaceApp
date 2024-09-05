using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MarketplaceApp.Model;
using MarketplaceApp.Services;
using System.ComponentModel;

namespace MarketplaceApp.ViewModel;


public partial class DetailPageViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private StoreProductResponse product;

    private readonly INavigationService _navigationService;

    public Command GoBackCommand { get; set; }



    public DetailPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        GoBackCommand = new Command(async () => await GoBackToMainPage());
    }


    [RelayCommand]
    private async Task GoBackToMainPage()
    {
        await _navigationService.GoBack();
    }


    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        object productObj;
        query.TryGetValue("Product", out productObj);
        if(productObj is StoreProductResponse product)
        {
            Product = product;
        }
    }
}