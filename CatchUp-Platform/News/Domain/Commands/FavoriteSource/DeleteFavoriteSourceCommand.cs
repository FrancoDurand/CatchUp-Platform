﻿namespace CatchUpPlatform.API.News.Domain.Commands.FavoriteSource
{
    public class DeleteFavoriteSourceCommand
    {
        public int Id { get; set; }

        public DeleteFavoriteSourceCommand(int id)
        {
            Id = id;
        }
    }

}
