using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Model
{
    public partial class StoreProductResponse : ObservableObject
    {
        [ObservableProperty]
        private int id;
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private double price;
        [ObservableProperty]
        private string description;
        [ObservableProperty]
        private string category;
        [ObservableProperty]
        private string image;
        [ObservableProperty]
        private Rating rating;

        [ObservableProperty]
        private int discount;
    }

    public partial class Rating : ObservableObject
    {
        [ObservableProperty]
        private double rate;
        [ObservableProperty]
        private int count;
    }
}
