using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Commands.FavoriteSource;
using CatchUpPlatform.API.News.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.CommandHandler
{
    public class CreateFavoriteSourceCommandHandler
    {
        private readonly IFavoriteSourceRepository _repository;

        public CreateFavoriteSourceCommandHandler(IFavoriteSourceRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateFavoriteSourceCommand command)
        {
            var newId = await _repository.GetNextId();
            var favoriteSource = new FavoriteSource(newId, command.NewsApiKey, command.SourceId);
            await _repository.AddAsync(favoriteSource);
            return newId;
        }
    }

}
