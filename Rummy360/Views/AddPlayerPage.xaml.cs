using Rummy360.Models;
using Rummy360.Views.Base;
using System.Collections.ObjectModel;

namespace Rummy360.Views;

public partial class AddPlayerPage : BasePage
{
    public ObservableCollection<AvatarColorItem> AvatarColors { get; set; }

    public AddPlayerPage()
	{
		InitializeComponent();

        AvatarColors = new ObservableCollection<AvatarColorItem>
        {
            new(){ Name="Green", AvatarColor=Color.FromArgb("#008E4E"), IsSelected=true },
            new(){ Name="Blue", AvatarColor=Color.FromArgb("#2962FF") },
            new(){ Name="Orange", AvatarColor=Color.FromArgb("#F97316") },
            new(){ Name="Purple", AvatarColor=Color.FromArgb("#9333EA") },
            new(){ Name="Red", AvatarColor=Color.FromArgb("#DC2626") },
            new(){ Name="Pink", AvatarColor=Color.FromArgb("#EC4899") },
            new(){ Name="Teal", AvatarColor=Color.FromArgb("#06B6D4") },
            new(){ Name="Gray", AvatarColor=Color.FromArgb("#64748B") }
        };

        BindingContext = this;
    }
    private void AvatarColorChanged(object? sender, AvatarColorItem color)
    {
        // Selected avatar colour available here.
    }
    private async void CreatePlayerClicked(object sender, EventArgs e)
    {
        // TODO: Save player (we'll implement tomorrow)
        await DisplayAlertAsync("Rummy360", "Create Player clicked.", "OK");
    }
    private async void CancelClicked(object sender, EventArgs e)
    {
        // TODO: Cancel player creation (we'll implement tomorrow)
        await DisplayAlertAsync("Rummy360", "Cancel clicked.", "OK");
    }
}