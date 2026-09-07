using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace Rummy360.Components;

public partial class ActionIconView : ContentView
{
    public ActionIconView()
    {
        InitializeComponent();
        UpdateShape();
    }

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(ActionIconView), "people.svg");

    public static readonly BindableProperty IconBackgroundProperty =
        BindableProperty.Create(nameof(IconBackground), typeof(Color), typeof(ActionIconView), Colors.Transparent);

    public static readonly BindableProperty ContainerSizeProperty =
        BindableProperty.Create(nameof(ContainerSize), typeof(double), typeof(ActionIconView), 52d,
            propertyChanged: (_, _, _) => { });

    public static readonly BindableProperty IconSizeProperty =
        BindableProperty.Create(nameof(IconSize), typeof(double), typeof(ActionIconView), 24d);

    public static readonly BindableProperty IsCircularProperty =
        BindableProperty.Create(nameof(IsCircular), typeof(bool), typeof(ActionIconView), true,
            propertyChanged: OnShapeChanged);

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

    public double ContainerSize
    {
        get => (double)GetValue(ContainerSizeProperty);
        set => SetValue(ContainerSizeProperty, value);
    }

    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public bool IsCircular
    {
        get => (bool)GetValue(IsCircularProperty);
        set => SetValue(IsCircularProperty, value);
    }

    static void OnShapeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((ActionIconView)bindable).UpdateShape();
    }

    void UpdateShape()
    {
        CircleBorder.StrokeShape = IsCircular
            ? new RoundRectangle { CornerRadius = new CornerRadius(999) }
            : new RoundRectangle { CornerRadius = new CornerRadius(16) };
    }
}