using System.Collections.Generic;
using System.Threading.Tasks;
using Eshop.Games.Models;
using Eshop.Games.Services.Nintendo;


namespace Eshop.Games.Services
{
    public class EshopService : IEshopService
    {
        INintendoService _NintendoService;
        public EshopService(Config config)
        {
            switch (config.Region)
            {
                case Region.NA:
                    _NintendoService = new NitendoNAService(config.System);
                    break;
                case Region.EU:
                    break;
                case Region.JP:
                    break;
            }
        }

        public async Task<IEnumerable<GameDetail>> GetGameDetail(Game game)
        {
            return await _NintendoService.GetGameDetail(game.Slug);
        }

        public async Task<IEnumerable<Game>> GetGames(Query query)
        {
            if (query.Index == 0)
            {
                List<Game> games = new List<Game>() ;
                int index = 1;
                var gameReturn = await _NintendoService.GetGames(query.Index, 200);

                while (gameReturn != null && gameReturn.Games?.Game?.Count > 0)
                {
                    games.AddRange(gameReturn.Games.Game);
                    index = index + 200;
                    gameReturn = await _NintendoService.GetGames(index, 200);
                }

                return games;
            }
            else
            {
                var gameReturn = await _NintendoService.GetGames(query.Index, query.Limit);
                return gameReturn?.Games?.Game;
            }
        }

       
    }
}
