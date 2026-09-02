using Rummy360.Models;

namespace Rummy360.Services;

public class PlayerService
{
    public List<Player> GetPlayers()
    {
        return new List<Player>
        {
            new Player
            {
                Id = 1, Name = "Bhanu Prakash", Initials = "BP", AvatarColor = "#0F7A3D", GamesPlayed = 12, GamesWon = 9, DealerTurns = 6, TotalPoints = 235
            },

            new Player
            {
                Id = 2, Name = "Ramesh Kumar", Initials = "RK", AvatarColor = "#2563EB", GamesPlayed = 10, GamesWon = 7, DealerTurns = 8, TotalPoints = 264
            },

            new Player
            {
                Id = 3, Name = "Suresh Kumar", Initials = "SK", AvatarColor = "#EA580C", GamesPlayed = 9, GamesWon = 5, DealerTurns = 5, TotalPoints = 301
            },
            new Player
            {
                Id = 4, Name = "Kiran Kumar", Initials = "KK", AvatarColor = "#9333EA", GamesPlayed = 8, GamesWon = 3, DealerTurns = 4, TotalPoints = 198
            }
        };
    }
}