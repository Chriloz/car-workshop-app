using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Bilvaerksted.Models;
using Bilvaerksted.Services;

namespace Bilvaerksted.ViewModels;

public partial class LavFakturaViewModel : ObservableObject
{
    [ObservableProperty]
    private int ordreNr;

    [ObservableProperty]
    private string mekanikerNavn = string.Empty;

    [ObservableProperty]
    private string materialer = string.Empty;

    [ObservableProperty]
    private decimal materialePris;

    [ObservableProperty]
    private decimal timer;

    [ObservableProperty]
    private decimal timepris;

    [ObservableProperty]
    private string statusBesked = string.Empty;

    private readonly DatabaseService _databaseService;

    public LavFakturaViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    [RelayCommand]
    private async Task GemAsync()
    {
        var faktura = new Faktura
        {
            OrdreNr = OrdreNr,
            Dato = DateTime.Now,
            MekanikerNavn = MekanikerNavn,
            Materialer = Materialer,
            MaterialePris = MaterialePris,
            Timer = Timer,
            Timepris = Timepris,
        };

        await _databaseService.GemFakturaAsync(faktura);

        StatusBesked = $"Faktura nr. {faktura.Id} gemt - total {faktura.Total:N2} kr.";

        OrdreNr = 0;
        MekanikerNavn = string.Empty;
        Materialer = string.Empty;
        MaterialePris = 0;
        Timer = 0;
        Timepris = 0;
    }
}
