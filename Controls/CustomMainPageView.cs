namespace MarketplaceApp.Controls;

class CustomMainPageView : ContentView
{
    public static readonly BindableProperty ImageProperty = BindableProperty.Create(
        nameof(Image), typeof(string), typeof(CustomMainPageView), default(string));

    public string Image
    {
        get => (string)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty CategoryProperty = BindableProperty.Create(
        nameof(Category), typeof(string), typeof(CustomMainPageView), default(string));

    public string Category
    {
        get => (string)GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(CustomMainPageView), default(string));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty PriceProperty = BindableProperty.Create(
    nameof(Price), typeof(decimal), typeof(CustomMainPageView), default(decimal));

    public decimal Price
    {
        get => (decimal)GetValue(PriceProperty);
        set => SetValue(PriceProperty, value);
    }

    public static readonly BindableProperty RatingProperty = BindableProperty.Create(
        nameof(Rating), typeof(double), typeof(CustomMainPageView), default(double));

    public double Rating
    {
        get => (double)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }
}
