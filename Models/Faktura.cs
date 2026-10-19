using SQLite;

namespace Bilvaerksted.Models;

public class Faktura
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public int OrdreNr { get; set; }

    public DateTime Dato { get; set; }

    public string MekanikerNavn { get; set; } = string.Empty;

    public string Materialer { get; set; } = string.Empty;

    public decimal MaterialePris { get; set; }

    public decimal Timer { get; set; }

    public decimal Timepris { get; set; }

    [Ignore]
    public decimal Total => Timer * Timepris + MaterialePris;
}
