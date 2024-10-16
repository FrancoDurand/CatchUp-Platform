namespace CatchUpPlatform.API.News.Domain.Commands
{
    public record CreateFavoriteSourceCommand
    {
        public string NewsApiKey { get; set; }
        public string SourceId { get; set; }

        public CreateFavoriteSourceCommand(string newsApiKey, string sourceId)
        {
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }
    }

}
