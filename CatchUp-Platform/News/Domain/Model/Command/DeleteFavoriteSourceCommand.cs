namespace CatchUpPlatform.API.News.Domain.Commands
{
    public record DeleteFavoriteSourceCommand
    {
        public int Id { get; set; }

        public DeleteFavoriteSourceCommand(int id)
        {
            Id = id;
        }
    }

}
