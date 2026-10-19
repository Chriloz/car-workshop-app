using CommunityToolkit.Mvvm.ComponentModel;
using Bilvaerksted.Models;
using Bilvaerksted.Services;
using CommunityToolkit.Mvvm.Input;

namespace Bilvaerksted.ViewModels;

public partial class BookOpgaveViewModel : ObservableObject
{
    [ObservableProperty]
    private string navn = string.Empty;
    [ObservableProperty]
    private string adresse = string.Empty;
    [ObservableProperty]
    private string bilmaerke = string.Empty;
    [ObservableProperty]
    private string model = string.Empty;
    [ObservableProperty]
    private string indregistreringsnummer = string.Empty;
    [ObservableProperty]
    private DateTime indleveringsDato = DateTime.Today;

    [ObservableProperty]
    private TimeSpan indleveringsTid;

    [ObservableProperty]
    private string note = string.Empty;

    [ObservableProperty]
    private string statusBesked = string.Empty;

    private readonly DatabaseService _databaseService;

    public BookOpgaveViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    [RelayCommand]
    private async Task GemAsync()
    {
        var opgave = new Opgave{
        Navn = Navn, 
        Adresse = Adresse,
        Bilmaerke = Bilmaerke,
        Model = Model,
        Indregistreringsnummer = Indregistreringsnummer,
        Indlevering = IndleveringsDato.Date + IndleveringsTid,
        Note = Note,
    };

    await _databaseService.GemOpgaveAsync(opgave);

    StatusBesked = $"Opgave gemt med ordrenummer {opgave.Id}";

    Navn = string.Empty;
    Adresse = string.Empty;
    Bilmaerke = string.Empty;
    Model = string.Empty;
    Indregistreringsnummer = string.Empty;
    Note = string.Empty;
    IndleveringsDato = DateTime.Today;
    IndleveringsTid = TimeSpan.Zero;

    }
}
