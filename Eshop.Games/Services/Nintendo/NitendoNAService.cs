using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Eshop.Games.Models;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using Eshop.Games.Helpers;

namespace Eshop.Games.Services.Nintendo
{
    internal class NitendoNAService :  BaseService, INintendoService
    {
        public NitendoNAService(System system)
        {

        }

        public Task<IEnumerable<GameDetail>> GetGameDetail(string slug)
        {
            throw new NotImplementedException();
        }

        public async Task<NintendoGame> GetGames(int index, int limit)
        {
            var response = await HttpClient.GetAsync($"{Constants.NintendoUSUrl}/json/content/get/filter/game?system=switch&sort=title&direction=asc&shop=ncom&limit={limit}&offset={index}").ConfigureAwait(false);


            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {

                    return JsonConvert.DeserializeObject<NintendoGame>(
                        await new StreamReader(responseStream)
                            .ReadToEndAsync().ConfigureAwait(false));

                }
            }

            return new NintendoGame();
        }

        public async Task<NintendoGameDetail> GetGameDetailsAsync(string gameSlug)
        {
            var response = await HttpClient.GetAsync($"{Constants.NintendoUSUrl}/json/content/get/game/{gameSlug}").ConfigureAwait(false);


            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {

                    return JsonConvert.DeserializeObject<NintendoGameDetail>(
                        await new StreamReader(responseStream)
                            .ReadToEndAsync().ConfigureAwait(false));

                }
            }

            return new NintendoGameDetail();
        }

    }
}
