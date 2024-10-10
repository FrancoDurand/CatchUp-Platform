using CatchUpPlatform.API.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.API.News.Domain.Repositories
{
    public interface IFavoriteSourceRepository
    {
        Task<int> GetNextId();
        Task AddAsync(FavoriteSource favoriteSource);
        Task<FavoriteSource?> GetByIdAsync(int id);
        Task<FavoriteSource?> GetByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);
        Task UpdateAsync(FavoriteSource favoriteSource);
        Task DeleteAsync(int id);
    }
}
