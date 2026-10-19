using SQLite;
using Bilvaerksted.Models;

namespace Bilvaerksted.Services;

public class DatabaseService
{

private readonly string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "Bilvaerksted.db");

private SQLiteAsyncConnection? _db;

private async Task InitAsync()
    {
        if (_db != null) {return;}

        _db = new SQLiteAsyncConnection(_dbPath);

        await _db.CreateTableAsync<Opgave>();
        await _db.CreateTableAsync<Faktura>();

    }

public async Task<int> GemOpgaveAsync(Opgave opgave)
    {
        await InitAsync();
        return await _db!.InsertAsync(opgave);
    }

public async Task<List<Opgave>> HentOpgaverForDatoAsync(DateTime dato)
    {
        await InitAsync();
        var start = dato.Date;
        var slut = dato.Date.AddDays(1);
        return await _db!.Table<Opgave>().Where(o => o.Indlevering >= start && o.Indlevering < slut).ToListAsync();
    }

public async Task<int> GemFakturaAsync(Faktura faktura)
    {
        await InitAsync();
        return await _db!.InsertAsync(faktura);
    }

public async Task<List<Faktura>> HentAlleFakturaerAsync()
    {
        await InitAsync();
        return await _db!.Table<Faktura>().OrderByDescending(f => f.Id).ToListAsync();
    }

}
