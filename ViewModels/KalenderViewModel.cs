using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Bilvaerksted.Models;
using Bilvaerksted.Services;
using System.Collections.ObjectModel;

namespace Bilvaerksted.ViewModels;

public partial class KalenderViewModel : ObservableObject
{
    [ObservableProperty]
    private DateTime valgtDato = DateTime.Today;

    public ObservableCollection<Opgave> Opgaver { get; } = new();

    private readonly DatabaseService _databaseService;

    public KalenderViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    [RelayCommand]
    private async Task HentOpgaverAsync()
    {
        var liste = await _databaseService.HentOpgaverForDatoAsync(ValgtDato);

        Opgaver.Clear();
        foreach (Opgave opgave in liste)
        {
            Opgaver.Add(opgave);
        }
    }
}
