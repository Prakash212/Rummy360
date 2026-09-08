using Microsoft.Maui.Controls;

namespace Rummy360.Views.Base;

public class BasePage : ContentPage
{
    protected override bool OnBackButtonPressed()
    {
        Dispatcher.Dispatch(async () =>
        {
            await Shell.Current.GoToAsync("..");
        });

        return true;
    }
}