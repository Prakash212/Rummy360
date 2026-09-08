using Microsoft.Maui.Controls;

namespace Rummy360.Components;

public partial class InputFieldView : ContentView
{
    public InputFieldView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(InputFieldView), string.Empty);

    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(InputFieldView), string.Empty);

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(InputFieldView), string.Empty);

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(InputFieldView), string.Empty, BindingMode.TwoWay);

    public static readonly BindableProperty IconSizeProperty =
    BindableProperty.Create(
        nameof(IconSize),
        typeof(double),
        typeof(InputFieldView),
        22d);

    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    private void InputBoxTapped(object? sender, TappedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            InputEntry.Focus();
        });
    }

    public void RemoveFocus()
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            InputEntry.Unfocus();
        });
    }
}