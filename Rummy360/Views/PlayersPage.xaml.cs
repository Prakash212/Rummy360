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
    protected override void OnAppearing()
    {
        base.OnAppearing();

        NavigationLogger.Log("👥 PlayersPage");
    }

    private async void AddPlayerTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddPlayerPage));
    }
}