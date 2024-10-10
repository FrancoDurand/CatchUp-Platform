using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using System.Threading.Tasks;

namespace CatchUpPlatform.API.News.Application.Services
{
    public class FavoriteSourceQueryService : IFavoriteSourceQueryService
    {
        private readonly IFavoriteSourceRepository _repository;

        public FavoriteSourceQueryService(IFavoriteSourceRepository repository)
        {
            _repository = repository;
        }

        public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            return await _repository.GetByIdAsync(query.Id);
        }

        public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
            return await _repository.GetByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId);
        }
    }
}
