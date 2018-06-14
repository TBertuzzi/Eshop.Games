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
    internal class NintendoNAService :  BaseService, INintendoService
    {
        public NintendoNAService(System system)
        {

        }

        public async Task<NintendoGame> GetGames(int index, int limit,Order order)
        {
            var response = await HttpClient.GetAsync($"{Constants.NintendoUSUrl}/json/content/get/filter/game?system=switch&sort=title&direction={order.ToString()}&shop=ncom&limit={limit}&offset={index}").ConfigureAwait(false);


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

        public async Task<NintendoGameDetail> GetGameDetail(string slug)
        {
            var response = await HttpClient.GetAsync($"{Constants.NintendoUSUrl}/json/content/get/game/{slug}").ConfigureAwait(false);


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
