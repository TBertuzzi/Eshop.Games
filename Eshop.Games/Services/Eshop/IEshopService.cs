using Eshop.Games.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Games.Services
{
    public interface IEshopService
    {
       Task<IEnumerable<Game>> GetGames(Query query);
       Task<IEnumerable<GameDetail>> GetGameDetail(Game game);
    }
}
