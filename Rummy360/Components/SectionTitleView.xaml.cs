using Microsoft.Maui.Controls;

namespace Rummy360.Components;

public partial class SectionTitleView : ContentView
{
    public SectionTitleView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(nameof(Icon), typeof(string), typeof(SectionTitleView), "⚡", propertyChanged: OnChanged);

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(SectionTitleView), "", propertyChanged: OnChanged);

    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(SectionTitleView), "", propertyChanged: OnChanged);

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

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

    static void OnChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var view = (SectionTitleView)bindable;

        view.IconLabel.Text = view.Icon;
        view.TitleLabel.Text = view.Title;
        view.SubtitleLabel.Text = view.Subtitle;

        view.SubtitleLabel.IsVisible = !string.IsNullOrWhiteSpace(view.Subtitle);
    }
}