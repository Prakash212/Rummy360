using System.Windows.Input;

namespace Rummy360.Components;

public partial class FloatingActionButtonView : ContentView
{
    public FloatingActionButtonView()
    {
        InitializeComponent();
        UpdateAppearance();
    }

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(FloatingActionButtonView), "plus.svg", propertyChanged: OnAppearanceChanged);

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(FloatingActionButtonView), string.Empty, propertyChanged: OnAppearanceChanged);

    public static readonly BindableProperty VariantProperty =
        BindableProperty.Create(nameof(Variant), typeof(string), typeof(FloatingActionButtonView), "Primary", propertyChanged: OnAppearanceChanged);

    public static readonly BindableProperty FabSizeProperty =
        BindableProperty.Create(nameof(FabSize), typeof(string), typeof(FloatingActionButtonView), "Large", propertyChanged: OnAppearanceChanged);

    public static readonly BindableProperty IsExtendedProperty =
        BindableProperty.Create(nameof(IsExtended), typeof(bool), typeof(FloatingActionButtonView), false, propertyChanged: OnAppearanceChanged);

    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(FloatingActionButtonView));

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

    public string Variant
    {
        get => (string)GetValue(VariantProperty);
        set => SetValue(VariantProperty, value);
    }

    public string FabSize
    {
        get => (string)GetValue(FabSizeProperty);
        set => SetValue(FabSizeProperty, value);
    }

    public bool IsExtended
    {
        get => (bool)GetValue(IsExtendedProperty);
        set => SetValue(IsExtendedProperty, value);
    }
    public event EventHandler? Clicked;

    static void OnAppearanceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((FloatingActionButtonView)bindable).UpdateAppearance();
    }

    void UpdateAppearance()
    {
        FabIcon.Source = Icon;

        double buttonSize = 60;
        double iconSize = 28;

        switch (FabSize)
        {
            case "Small":
                buttonSize = 48;
                iconSize = 20;
                break;

            case "Medium":
                buttonSize = 56;
                iconSize = 24;
                break;

            case "Large":
                buttonSize = 64;
                iconSize = 28;
                break;
        }

        FabBorder.WidthRequest = buttonSize;
        FabBorder.HeightRequest = buttonSize;
        FabIcon.WidthRequest = iconSize;
        FabIcon.HeightRequest = iconSize;

        Color background = Color.FromArgb("#0F7A3D");
        Color textColor = Colors.White;
        Color borderColor = Colors.Transparent;
        double borderThickness = 0;

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

            case "Outline":
                background = Colors.White;
                borderColor = Color.FromArgb("#D1D5DB");
                borderThickness = 1;
                textColor = Color.FromArgb("#1F2937");
                break;
        }

        FabBorder.Background = background;
        FabBorder.Stroke = borderColor;
        FabBorder.StrokeThickness = borderThickness;

        TextBorder.Background = background;
        FabText.Text = Text;
        FabText.TextColor = textColor;
        TextBorder.IsVisible = IsExtended && !string.IsNullOrWhiteSpace(Text);

        FabBorder.Shadow = new Shadow
        {
            Brush = Brush.Black,
            Opacity = 0.18f,
            Radius = 16,
            Offset = new Point(0, 6)
        };
    }

    async void FabTapped(object? sender, TappedEventArgs e)
    {
        await FabBorder.ScaleToAsync(0.92, 80);
        await FabBorder.ScaleToAsync(1, 80);

        Clicked?.Invoke(this, EventArgs.Empty);
    }
}