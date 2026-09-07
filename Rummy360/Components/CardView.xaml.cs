using Microsoft.Maui.Controls;

namespace Rummy360.Components;

public partial class CardView : ContentView
{
    public CardView()
    {
        InitializeComponent();
    }

    public event EventHandler? Tapped;

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(CardView), "");

    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(CardView), "");

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(CardView), "");

    public static readonly BindableProperty IconBackgroundProperty =
        BindableProperty.Create(nameof(IconBackground), typeof(Color), typeof(CardView),
            Color.FromArgb("#EFF6FF"));

    public static readonly BindableProperty CardLayoutProperty =
        BindableProperty.Create(
            nameof(CardLayout),
            typeof(string),
            typeof(CardView),
            "Vertical");

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Subtitle
    {
        get => (string)GetValue(SubtitleProperty);
        set => SetValue(SubtitleProperty, value);
    }

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public Color IconBackground
    {
        get => (Color)GetValue(IconBackgroundProperty);
        set => SetValue(IconBackgroundProperty, value);
    }
    public string CardLayout
    {
        get => (string)GetValue(CardLayoutProperty);
        set => SetValue(CardLayoutProperty, value);
    }

    private async void CardTapped(object? sender, TappedEventArgs e)
    {
        await this.ScaleToAsync(0.97, 70);
        await this.ScaleToAsync(1, 70);

        Tapped?.Invoke(this, EventArgs.Empty);
    }
}