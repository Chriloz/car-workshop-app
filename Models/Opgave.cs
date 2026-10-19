using SQLite; 

namespace Bilvaerksted.Models;

public class Opgave
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Navn { get; set; } = string.Empty;
    public string Adresse { get; set; } = string.Empty;
    public string Bilmaerke { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Indregistreringsnummer { get; set; } = string.Empty;
    public DateTime Indlevering { get; set; }
    public string Note { get; set; } = string.Empty;

}