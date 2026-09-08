using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rummy360.Models;

public class AvatarColorItem : INotifyPropertyChanged
{
    private bool isSelected;

    public string Name { get; set; } = string.Empty;

    public Color AvatarColor { get; set; } = Colors.Green;

    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}