
namespace MarketplaceApp.Controls;

public partial class CustomMainPageControl : Border
{

    public static readonly BindableProperty ImageProperty = BindableProperty.Create(
    nameof(Image), typeof(string), typeof(CustomMainPageControl), default(string));

    public string Image
    {
        get => (string)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty CategoryProperty = BindableProperty.Create(
        nameof(Category), typeof(string), typeof(CustomMainPageControl), default(string));

    public string Category
    {
        get => (string)GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(CustomMainPageControl), default(string));

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty PriceProperty = BindableProperty.Create(
    nameof(Price), typeof(decimal), typeof(CustomMainPageControl), default(decimal));

    public decimal Price
    {
        get => (decimal)GetValue(PriceProperty);
        set => SetValue(PriceProperty, value);
    }

    public static readonly BindableProperty RatingProperty = BindableProperty.Create(
        nameof(Rating), typeof(double), typeof(CustomMainPageControl), default(double));

    public double Rating
    {
        get => (double)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }


    public static readonly BindableProperty DiscountProperty = BindableProperty.Create(
        nameof(Discount),
        typeof(int),
        typeof(CustomMainPageControl),
        default(int),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var view = (CustomMainPageControl)bindable;
            var discount = (int)newValue;

            if (discount != 0)
            {
                view.DiscountLabel.IsVisible = true;
                view.DiscountLabel.Text = view.Price.ToString("C");
                view.DiscountLabel.TextDecorations = TextDecorations.Strikethrough;
                view.Price -= view.Price * ((decimal)discount / 100);
            }
        });
        
    //private static void DiscountChanged(BindableObject bindable, object oldValue, object newValue)
    //{
        
    //}

    public int Discount
    {
        get => (int)GetValue(DiscountProperty);
        set => SetValue(DiscountProperty, value);
    }

    public CustomMainPageControl()
    {
        InitializeComponent();
    }
}