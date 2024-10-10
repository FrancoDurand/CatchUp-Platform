﻿using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using System.Threading.Tasks;

namespace CatchUpPlatform.API.News.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
        Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    }
}
