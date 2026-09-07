namespace Rummy360.Components;

public partial class PageHeaderView : ContentView
{
    public PageHeaderView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(PageHeaderView), string.Empty,
            propertyChanged: (b, o, n) =>
            {
                ((PageHeaderView)b).TitleLabel.Text = n?.ToString();
            });

    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(PageHeaderView), string.Empty,
            propertyChanged: (b, o, n) =>
            {
                ((PageHeaderView)b).SubtitleLabel.Text = n?.ToString();
            });

    public static readonly BindableProperty DescriptionProperty =
        BindableProperty.Create(nameof(Description), typeof(string), typeof(PageHeaderView), string.Empty,
            propertyChanged: (b, o, n) =>
            {
                var view = (PageHeaderView)b;
                var text = n?.ToString() ?? "";

                view.DescriptionLabel.Text = text;
                view.DescriptionLabel.IsVisible = !string.IsNullOrWhiteSpace(text);
            });

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

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }
}