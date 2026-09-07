namespace Rummy360.Components;

public partial class PrimaryButtonView : ContentView
{
	public PrimaryButtonView()
	{
		InitializeComponent();
	}
    public static readonly BindableProperty TextProperty =
       BindableProperty.Create(
           nameof(Text),
           typeof(string),
           typeof(PrimaryButtonView),
           string.Empty,
           propertyChanged: OnTextChanged);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((PrimaryButtonView)bindable).ButtonText.Text = newValue?.ToString();
    }
}