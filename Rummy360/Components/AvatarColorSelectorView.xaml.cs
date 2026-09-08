using Rummy360.Models;
using System.Collections.ObjectModel;

namespace Rummy360.Components;

public partial class AvatarColorSelectorView : ContentView
{
    public AvatarColorSelectorView()
    {
        InitializeComponent();
    }

    // Runtime Initials
    public static readonly BindableProperty InitialsProperty =
        BindableProperty.Create(
            nameof(Initials),
            typeof(string),
            typeof(AvatarColorSelectorView),
            "BP");

    public string Initials
    {
        get => (string)GetValue(InitialsProperty);
        set => SetValue(InitialsProperty, value);
    }

    // Avatar Colors Collection
    public static readonly BindableProperty ItemsSourceProperty =
        BindableProperty.Create(
            nameof(ItemsSource),
            typeof(ObservableCollection<AvatarColorItem>),
            typeof(AvatarColorSelectorView));

    public ObservableCollection<AvatarColorItem> ItemsSource
    {
        get => (ObservableCollection<AvatarColorItem>)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    // Event to parent page
    public event EventHandler<AvatarColorItem>? SelectionChanged;

    private void AvatarTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Border border)
            return;

        if (border.BindingContext is not AvatarColorItem selectedItem)
            return;

        if (ItemsSource == null)
            return;

        // Unselect all avatars
        foreach (var item in ItemsSource)
            item.IsSelected = false;

        // Select tapped avatar
        selectedItem.IsSelected = true;

        // Refresh BindableLayout
        BindableLayout.SetItemsSource(AvatarContainer, null);
        BindableLayout.SetItemsSource(AvatarContainer, ItemsSource);

        // Notify parent page
        SelectionChanged?.Invoke(this, selectedItem);
    }
}