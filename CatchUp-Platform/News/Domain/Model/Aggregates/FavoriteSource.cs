namespace CatchUpPlatform.API.News.Domain.Model.Aggregates
{
    /// <summary>
    /// Aggregate representing a favorite news source for a user.
    /// </summary>
    public class FavoriteSource
    {
        public int Id { get; private set; }
        public string NewsApiKey { get; private set; }
        public string SourceId { get; private set; }

        public FavoriteSource(int id, string newsApiKey, string sourceId)
        {
            Id = id;
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }

        public void Update(string newsApiKey, string sourceId)
        {
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }
    }


}
