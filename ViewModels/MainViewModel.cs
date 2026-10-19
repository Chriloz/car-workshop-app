using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Bilvaerksted.Views;

namespace Bilvaerksted.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private async Task GaaTilBookOpgaveAsync()
    {
        await Shell.Current.GoToAsync(nameof(BookOpgavePage));
    }

    [RelayCommand]
    private async Task GaaTilKalenderAsync()
    {
        await Shell.Current.GoToAsync(nameof(KalenderPage));
    }

    [RelayCommand]
    private async Task GaaTilLavFakturaAsync()
    {
        await Shell.Current.GoToAsync(nameof(LavFakturaPage));
    }

    [RelayCommand]
    private async Task GaaTilSeFakturaerAsync()
    {
        await Shell.Current.GoToAsync(nameof(SeFakturaerPage));
    }
}
