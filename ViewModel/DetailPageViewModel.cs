using CommunityToolkit.Mvvm.ComponentModel;
using MarketplaceApp.Model;
using MarketplaceApp.Services;
using System.ComponentModel;

namespace MarketplaceApp.ViewModel;


public partial class DetailPageViewModel : ObservableObject, INotifyPropertyChanged, IQueryAttributable
{
    [ObservableProperty]
    private StoreProductResponse product;

    private readonly IApiClientService _apiClientService;


    public DetailPageViewModel()
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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