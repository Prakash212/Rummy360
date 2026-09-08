using Rummy360.Models;
using Rummy360.Services;
using Rummy360.Views.Base;

namespace Rummy360.Views;

public partial class PlayersPage : BasePage
{
    public List<Player> Players { get; set; } = new();

    public PlayersPage()
    {
        InitializeComponent();

        var playerService = Application.Current!
            .Handler!
            .MauiContext!
            .Services
            .GetService<PlayerService>();

        if (playerService != null)
            Players = playerService.GetPlayers();

        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavigationLogger.Log("👥 PlayersPage");
    }

    private async void AddPlayerTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddPlayerPage));
    }
}