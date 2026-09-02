using Rummy360.Models;
using Rummy360.Services;

namespace Rummy360.Views;

public partial class PlayersPage : ContentPage
{
    public List<Player> Players { get; set; } = new();

    public PlayersPage()
    {
        InitializeComponent();

        // Get PlayerService from MAUI Dependency Injection
        var playerService = Application.Current!
            .Handler!
            .MauiContext!
            .Services
            .GetService<PlayerService>();

        if (playerService != null)
        {
            Players = playerService.GetPlayers();
        }

        BindingContext = this;
    }
}