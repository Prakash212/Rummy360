using Microsoft.Maui.Graphics;

namespace Rummy360.Components;

public partial class ButtonView : ContentView
{
    public ButtonView()
    {
        InitializeComponent();
        ApplyStyle();
    }

    // Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ButtonView), string.Empty, propertyChanged: (b, o, n) => { ((ButtonView)b).TextLabel.Text = n?.ToString(); });
    // Icon
    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(ButtonView), string.Empty, propertyChanged: (b, o, n) => { var view = (ButtonView)b; view.IconLabel.Text = n?.ToString(); view.IconLabel.IsVisible = !string.IsNullOrWhiteSpace(view.Icon); });
    // Variant
    public static readonly BindableProperty VariantProperty = BindableProperty.Create(nameof(Variant), typeof(string), typeof(ButtonView), "Primary", propertyChanged: (b, o, n) => { ((ButtonView)b).ApplyStyle(); });
    // Outline
    public static readonly BindableProperty IsOutlinedProperty = BindableProperty.Create(nameof(IsOutlined), typeof(bool), typeof(ButtonView), false, propertyChanged: (b, o, n) => { ((ButtonView)b).ApplyStyle(); });

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

    public string Variant
    {
        get => (string)GetValue(VariantProperty);
        set => SetValue(VariantProperty, value);
    }

    public bool IsOutlined
    {
        get => (bool)GetValue(IsOutlinedProperty);
        set => SetValue(IsOutlinedProperty, value);
    }

    void ApplyStyle()
    {
        Color background = Colors.Green;
        Color text = Colors.White;

        switch (Variant)
        {
            case "Success":
                background = Color.FromArgb("#16A34A");
                break;

            case "Info":
                background = Color.FromArgb("#2563EB");
                break;

            case "Warning":
                background = Color.FromArgb("#D97706");
                break;

            case "Danger":
                background = Color.FromArgb("#DC2626");
                break;

            case "Secondary":
                background = Color.FromArgb("#64748B");
                break;

            default:
                background = Color.FromArgb("#047857");
                break;
        }

        if (IsOutlined)
        {
            ButtonBorder.BackgroundColor = Colors.White;
            ButtonBorder.Stroke = background;
            ButtonBorder.StrokeThickness = 2;

            text = background;
        }
        else
        {
            ButtonBorder.BackgroundColor = background;
            ButtonBorder.StrokeThickness = 0;
        }

        TextLabel.TextColor = text;
        IconLabel.TextColor = text;
    }
}