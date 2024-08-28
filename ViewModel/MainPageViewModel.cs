using MarketplaceApp.Helpers.Icons;
using MarketplaceApp.Model;
using MarketplaceApp.Model.Wrappers;
using MarketplaceApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly IApiClientService _apiClientService;
        public ObservableCollection<StoreProductResponse> Products { get; set; }
        public ObservableCollection<CategoryWrapper> Categories { get; set; }
        public Command<CategoryWrapper> SelectCategoryCommand { get; }
        public Command RefreshCommand { get; set; }

        private bool _isRefreshing;

        private bool _isEmpty;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                if (_isRefreshing != value)
                {
                    _isRefreshing = value;
                    OnPropertyChanged(nameof(IsRefreshing));
                }
            }
        }

        public bool IsEmpty 
        {
            get => _isEmpty;
            set 
            {
                if (_isEmpty != value)
                {
                    _isEmpty = value;
                    OnPropertyChanged(nameof(IsEmpty));
                }
            }
        }

        public MainPageViewModel(IApiClientService apiClientService)
        {
            _apiClientService = apiClientService;
            Products = new ObservableCollection<StoreProductResponse>();
            Categories = new ObservableCollection<CategoryWrapper>();
            RefreshCommand = new Command(async () => await RefreshProducts());
            SelectCategoryCommand = new Command<CategoryWrapper>(async (param) => await OnCategorySelected(param));

            GetProducts();
            LoadCategories();
        }

        private async Task OnCategorySelected(CategoryWrapper selectedCategory)
        {
            var response = await _apiClientService.GetProducts();

            if (response.IsSuccessful && response.Data != null)
            {
                Products.Clear();

                var filteredProducts = selectedCategory.RealName == "All"
                    ? response.Data
                    : response.Data.Where(p => p.Category == selectedCategory.RealName);

                foreach (var product in filteredProducts)
                {
                    Products.Add(product);
                }
            }
        }

        public async Task GetProducts()
        {
            var response = await _apiClientService.GetProducts();

            if (response.IsSuccessful && response.Data != null)
            {
                IsEmpty = false;
                Products.Clear();

                foreach (var product in response.Data)
                {
                    Products.Add(product);
                }
                return;
            }
            IsEmpty = true;
        }

        private async Task LoadCategories()
        {
            var response = await _apiClientService.GetCategories(); 

            if (response.IsSuccessful && response.Data != null)
            {
                Categories?.Clear();
                Categories.Add(new CategoryWrapper
                {
                    RealName = "All",
                    Icon = GetIcon("All"),
                    FormatName = FormatName("All"),
                });
                foreach (var category in response.Data)
                {
                    Categories.Add(new CategoryWrapper
                    {
                        RealName = category,
                        Icon = GetIcon(category),
                        FormatName = FormatName(category),
                    });
                }
            }
        }

        private string FormatName(string category)
        {
            switch (category)
            {
                case "electronics":
                    return "Electronics";
                case "jewelery":
                    return "Jewerlys";
                case "men's clothing":
                    return "Man";
                case "women's clothing":
                    return "Women";
                case "All":
                    return "All";
                default:
                    return "NA";
            }
        }

        private string GetIcon(string category)
        {
            switch (category)
            {
                case "electronics":
                    return Icons.Electronic;
                case "jewelery":
                    return Icons.Jewerly;
                case "men's clothing":
                    return Icons.Man;
                case "women's clothing":
                    return Icons.Women;
                case "All":
                    return Icons.Home;
                default:
                    return Icons.Home;
            }
        }

        private async Task RefreshProducts()
        {
            IsRefreshing = true;
            await GetProducts();
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



//Products = new ObservableCollection<Product>
//{
//new Product { ImageSource = "shirt.jpg", Type = "Shirt", Name = "Essential Man Shirt", Rating = 4, Price = 19.99m },
//new Product { ImageSource = "pants.jpg", Type = "Pants", Name = "denim pants", Rating = 5, Price = 22.80m },
//new Product { ImageSource = "blackshirt.jpg", Type = "Shirt", Name = "Black Shirt", Rating = 5, Price = 17m },
//new Product { ImageSource = "shirt.jpg", Type = "Shirt", Name = "Comfy Shirt", Rating = 3, Price = 15m }
//};