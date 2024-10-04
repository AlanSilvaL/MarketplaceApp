using System.Diagnostics;

namespace MarketplaceApp.Controls;

public partial class CustomPromotionControl : Border
{
    public static readonly BindableProperty BFImageProperty = BindableProperty.Create(
    nameof(BFImage), typeof(string), typeof(CustomPromotionControl), default(string));

    public string BFImage
    {
        get => (string)GetValue(BFImageProperty);
        set => SetValue(BFImageProperty, value);
    }

    public static readonly BindableProperty BlackFridayProperty = BindableProperty.Create(
    nameof(BlackFriday), typeof(bool), typeof(CustomPromotionControl), default(bool));

    public bool BlackFriday
    {
        get => (bool)GetValue(BlackFridayProperty);
        set => SetValue(BlackFridayProperty, value);
    }

    public static readonly BindableProperty BuyCommandProperty = BindableProperty.Create(
    nameof(BuyCommand), typeof(Command), typeof(CustomPromotionControl));
    public Command BuyCommand
    {
        get => (Command)GetValue(BuyCommandProperty);
        set => SetValue(BuyCommandProperty, value);
    }

    public CustomPromotionControl()
	{
		InitializeComponent();
    }
}