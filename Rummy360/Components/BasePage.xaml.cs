using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace Rummy360.Controls;

[ContentProperty(nameof(BodyContent))]
public partial class BasePage : ContentView
{
    public BasePage()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty HeaderCaptionProperty =
        BindableProperty.Create(nameof(HeaderCaption), typeof(string), typeof(BasePage), string.Empty);

    public static readonly BindableProperty HeaderTitleProperty =
        BindableProperty.Create(nameof(HeaderTitle), typeof(string), typeof(BasePage), string.Empty);

    public static readonly BindableProperty HeaderSubtitleProperty =
        BindableProperty.Create(nameof(HeaderSubtitle), typeof(string), typeof(BasePage), string.Empty);

    public static readonly BindableProperty BodyContentProperty =
        BindableProperty.Create(nameof(BodyContent), typeof(View), typeof(BasePage));

    public string HeaderCaption
    {
        get => (string)GetValue(HeaderCaptionProperty);
        set => SetValue(HeaderCaptionProperty, value);
    }

    public string HeaderTitle
    {
        get => (string)GetValue(HeaderTitleProperty);
        set => SetValue(HeaderTitleProperty, value);
    }

    public string HeaderSubtitle
    {
        get => (string)GetValue(HeaderSubtitleProperty);
        set => SetValue(HeaderSubtitleProperty, value);
    }

    public View BodyContent
    {
        get => (View)GetValue(BodyContentProperty);
        set => SetValue(BodyContentProperty, value);
    }
}