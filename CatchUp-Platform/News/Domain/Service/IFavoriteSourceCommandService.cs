using CatchUpPlatform.API.News.Domain.Commands;
using CatchUpPlatform.API.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.API.News.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand query);
        Task<FavoriteSource?> Handle(DeleteFavoriteSourceCommand query);
        Task<FavoriteSource?> Handle(UpdateFavoriteSourceCommand query);
    }
}
