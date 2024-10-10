using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FavoriteSourceRepository : IFavoriteSourceRepository
{
    private readonly List<FavoriteSource> _favoriteSources = new();

    public async Task<int> GetNextId()
    {
        // Si la lista está vacía, empieza en 1, de lo contrario, devuelve el mayor ID + 1
        int nextId = _favoriteSources.Any() ? _favoriteSources.Max(x => x.Id) + 1 : 1;
        return await Task.FromResult(nextId);
    }

    public async Task AddAsync(FavoriteSource source)
    {
        _favoriteSources.Add(source);
        await Task.CompletedTask;
    }

    public async Task UpdateAsync(FavoriteSource source)
    {
        var existingSource = _favoriteSources.FirstOrDefault(x => x.Id == source.Id);
        if (existingSource != null)
        {
            existingSource.Update(source.NewsApiKey, source.SourceId);
        }
        await Task.CompletedTask;
    }

    public async Task DeleteAsync(int id)
    {
        var source = _favoriteSources.FirstOrDefault(x => x.Id == id);
        if (source != null)
        {
            _favoriteSources.Remove(source);
        }
        await Task.CompletedTask;
    }

    public async Task<FavoriteSource?> GetByIdAsync(int id)
    {
        return await Task.FromResult(_favoriteSources.FirstOrDefault(x => x.Id == id));
    }

    public async Task<FavoriteSource?> GetByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId)
    {
        // Devuelve el primer `FavoriteSource` que coincida con `NewsApiKey` y `SourceId`
        return await Task.FromResult(_favoriteSources.FirstOrDefault(x => x.NewsApiKey == newsApiKey && x.SourceId == sourceId));
    }
}
