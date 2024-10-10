using CatchUpPlatform.API.News.Domain.Commands.FavoriteSource;
using CatchUpPlatform.API.News.Domain.Repositories;

namespace CatchUpPlatform.API.News.Application.CommandHandler
{
    public class DeleteFavoriteSourceCommandHandler
    {
        private readonly IFavoriteSourceRepository _repository;

        public DeleteFavoriteSourceCommandHandler(IFavoriteSourceRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteFavoriteSourceCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }

}
