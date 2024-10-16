namespace CatchUpPlatform.API.News.Domain.Commands
{
    public record UpdateFavoriteSourceCommand
    {
        public int Id { get; set; }
        public string NewsApiKey { get; set; }
        public string SourceId { get; set; }

        public UpdateFavoriteSourceCommand(int id, string newsApiKey, string sourceId)
        {
            Id = id;
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }
    }

}
