namespace Rummy360.Components;

public partial class SecondaryButtonView : ContentView
{
	public SecondaryButtonView()
	{
		InitializeComponent();
	}
    public static readonly BindableProperty TextProperty =
       BindableProperty.Create(
           nameof(Text),
           typeof(string),
           typeof(SecondaryButtonView),
           string.Empty,
           propertyChanged: OnTextChanged);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((SecondaryButtonView)bindable).ButtonText.Text = newValue?.ToString();
    }
}