using System.Collections.Generic;
using System.Threading.Tasks;
using Eshop.Games.Models;
using Eshop.Games.Services.Nintendo;
using System;


namespace Eshop.Games.Services
{
    public class EshopService : IEshopService
    {
        INintendoService _NintendoService;
        public EshopService(Config config)
        {
            if (config.System == System.Nintendo3DS)
                throw new Exception("System not implemented");

            switch (config.Region)
            {
                case Region.NA:
                    _NintendoService = new NintendoNAService(config.System);
                    break;
                case Region.EU:
                    throw new Exception("Region not implemented");
                case Region.JP:
                    throw new Exception("Region not implemented");
            }
        }

        public async Task<GameDetail> GetGameDetail(Game game)
        {
            var gameDetail = await _NintendoService.GetGameDetail(game.Slug);
            return gameDetail.Game;
        }

        public async Task<IEnumerable<Game>> GetGames(Query query)
        {
            if (query.Index == 0)
            {
                List<Game> games = new List<Game>() ;
                int index = 1;
                var gameReturn = await _NintendoService.GetGames(query.Index, 200, query.Order);

                while (gameReturn != null && gameReturn.Games?.Game?.Count > 0)
                {
                    games.AddRange(gameReturn.Games.Game);
                    index = index + 200;
                    gameReturn = await _NintendoService.GetGames(index, 200, query.Order);
                }

                return games;
            }
            else
            {
                var gameReturn = await _NintendoService.GetGames(query.Index, query.Limit, query.Order);
                return gameReturn?.Games?.Game;
            }
        }

       
    }
}
