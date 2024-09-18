namespace MarketplaceApp.Controls;

public partial class CustomDetailPageControl : ContentView
{
  
    public static readonly BindableProperty ProductImageProperty = BindableProperty.Create(
        nameof(ProductImage), typeof(string), typeof(CustomDetailPageControl), default(string));

    public string ProductImage
    {
        get => (string)GetValue(ProductImageProperty);
        set => SetValue(ProductImageProperty, value);
    }

   
    public static readonly BindableProperty ProductCategoryProperty = BindableProperty.Create(
        nameof(ProductCategory), typeof(string), typeof(CustomDetailPageControl), default(string));

    public string ProductCategory
    {
        get => (string)GetValue(ProductCategoryProperty);
        set => SetValue(ProductCategoryProperty, value);
    }

    public static readonly BindableProperty ProductTitleProperty = BindableProperty.Create(
        nameof(ProductTitle), typeof(string), typeof(CustomDetailPageControl), default(string));

    public string ProductTitle
    {
        get => (string)GetValue(ProductTitleProperty);
        set => SetValue(ProductTitleProperty, value);
    }

    public static readonly BindableProperty ProductPriceProperty = BindableProperty.Create(
        nameof(ProductPrice), typeof(decimal), typeof(CustomDetailPageControl), default(decimal));

    public decimal ProductPrice
    {
        get => (decimal)GetValue(ProductPriceProperty);
        set => SetValue(ProductPriceProperty, value);
    }

    public static readonly BindableProperty ProductRatingProperty = BindableProperty.Create(
        nameof(ProductRating), typeof(double), typeof(CustomDetailPageControl), default(double));

    public double ProductRating
    {
        get => (double)GetValue(ProductRatingProperty);
        set => SetValue(ProductRatingProperty, value);
    }

    public CustomDetailPageControl()
    {
        InitializeComponent();
    }
}
