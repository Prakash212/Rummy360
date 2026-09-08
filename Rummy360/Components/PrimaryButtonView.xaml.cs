using Microsoft.Maui.Controls;

namespace Rummy360.Components;

public partial class PrimaryButtonView : ContentView
{
    public PrimaryButtonView()
    {
        InitializeComponent();
    }

    // Event (CS8618 Fix)
    public event EventHandler? Clicked;

    // Button Text
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(PrimaryButtonView), string.Empty);

    // Button Icon
    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(PrimaryButtonView), string.Empty);

    // Background Color (CS0108 Fix)
    public static readonly BindableProperty ButtonBackgroundProperty =
        BindableProperty.Create(nameof(ButtonBackground), typeof(Color), typeof(PrimaryButtonView), Colors.Green);

    // Text Color (CS0108 Fix)
    public static readonly BindableProperty ButtonTextColorProperty =
        BindableProperty.Create(nameof(ButtonTextColor), typeof(Color), typeof(PrimaryButtonView), Colors.White);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public Color ButtonBackground
    {
        get => (Color)GetValue(ButtonBackgroundProperty);
        set => SetValue(ButtonBackgroundProperty, value);
    }

    public Color ButtonTextColor
    {
        get => (Color)GetValue(ButtonTextColorProperty);
        set => SetValue(ButtonTextColorProperty, value);
    }

    private void ButtonTapped(object? sender, TappedEventArgs e)
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}