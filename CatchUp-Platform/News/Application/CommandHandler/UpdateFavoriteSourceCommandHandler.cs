using CatchUpPlatform.API.News.Domain.Commands.FavoriteSource;
using CatchUpPlatform.API.News.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.CommandHandler
{
    public class UpdateFavoriteSourceCommandHandler
    {
        private readonly IFavoriteSourceRepository _repository;

        public UpdateFavoriteSourceCommandHandler(IFavoriteSourceRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFavoriteSourceCommand command)
        {
            var favoriteSource = await _repository.GetByIdAsync(command.Id);
            if (favoriteSource != null)
            {
                favoriteSource.Update(command.NewsApiKey, command.SourceId);
                await _repository.UpdateAsync(favoriteSource);
            }
        }
    }

}
