using CatchUpPlatform.API.News.Domain.Commands;
using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Services;

namespace CatchUpPlatform.API.News.Application.Services
{
    public class FavoriteSourceCommandService : IFavoriteSourceCommandService
    {
        public Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand query)
        {
            throw new NotImplementedException();
        }
        public Task<FavoriteSource?> Handle(DeleteFavoriteSourceCommand query)
        {
            throw new NotImplementedException();
        }
        public Task<FavoriteSource?> Handle(UpdateFavoriteSourceCommand query)
        {
            throw new NotImplementedException();
        }
    }
}
