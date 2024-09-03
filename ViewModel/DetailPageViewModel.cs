using MarketplaceApp.Model;
using MarketplaceApp.Services;
using System.ComponentModel;

namespace MarketplaceApp.ViewModel;

public class DetailPageViewModel : INotifyPropertyChanged
{

    private StoreProductResponse _product;
    private readonly IApiClientService _apiClientService;


    public StoreProductResponse Product
    {
        get => _product;
        set
        {
            if (_product != value)
            {
                _product = value;
                OnPropertyChanged(nameof(_product));
            }
        }
    }

    public DetailPageViewModel()
    {
        Product = new StoreProductResponse()
        {
            Title = "pants",
            Price = 188,
            Description = "pants",
            Category  = "pants",
            Image = "https://www.lazzarmexico.com/uploads/productos/55/pantalo%CC%81n_marino_sinpinzas.jpg",
            Rating = new Rating()
            {
                Rate = 1,
                Count = 1,
            }
        };
    }

    public async Task LoadProduct()
    {
        var response = await _apiClientService.GetProducts();

        if (response.IsSuccessful && response.Data != null)
        {
            Product = new StoreProductResponse()
            {
                Title = "pants",
                Price = 188,
                Description = "pants",
                Category = "pants",
                Image = "https://www.lazzarmexico.com/uploads/productos/55/pantalo%CC%81n_marino_sinpinzas.jpg",
                Rating = new Rating()
                {
                    Rate = 1,
                    Count = 1,
                }
            };
        }
    }


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
