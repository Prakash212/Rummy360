namespace Rummy360.Models;

public class Player
{
    // Unique ID (SQLite later)
    public int Id { get; set; }

    // Full Name
    public string Name { get; set; } = string.Empty;

    // Avatar initials (BP, RK...)
    public string Initials { get; set; } = string.Empty;

    // Circle avatar color
    public string AvatarColor { get; set; } = "#0F7A3D";

    // Statistics (used later)
    public int GamesPlayed { get; set; }

    public int GamesWon { get; set; }

    public int DealerTurns { get; set; }

    public int TotalPoints { get; set; }

    public bool IsActive { get; set; } = true;
}