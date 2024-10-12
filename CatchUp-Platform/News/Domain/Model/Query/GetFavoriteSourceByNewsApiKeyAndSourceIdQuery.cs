namespace CatchUpPlatform.API.News.Domain.Model.Queries
{
    public class GetFavoriteSourceByNewsApiKeyAndSourceIdQuery
    {
        public string NewsApiKey { get; }
        public string SourceId { get; }

        public GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string newsApiKey, string sourceId)
        {
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }
    }
}
