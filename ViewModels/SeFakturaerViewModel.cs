using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Bilvaerksted.Models;
using Bilvaerksted.Services;

namespace Bilvaerksted.ViewModels;

public partial class SeFakturaerViewModel : ObservableObject
{
    public ObservableCollection<Faktura> Fakturaer { get; } = new();

    private readonly DatabaseService _databaseService;

    public SeFakturaerViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    [RelayCommand]
    private async Task HentFakturaerAsync()
    {
        var liste = await _databaseService.HentAlleFakturaerAsync();

        Fakturaer.Clear();
        foreach (Faktura faktura in liste)
        {
            Fakturaer.Add(faktura);
        }
    }
}
