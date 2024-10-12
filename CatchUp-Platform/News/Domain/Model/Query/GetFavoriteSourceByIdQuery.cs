namespace CatchUpPlatform.API.News.Domain.Model.Queries
{
    public class GetFavoriteSourceByIdQuery
    {
        public int Id { get; }

        public GetFavoriteSourceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
