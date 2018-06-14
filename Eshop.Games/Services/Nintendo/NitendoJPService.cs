using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eshop.Games.Helpers;
using Eshop.Games.Models;
using Newtonsoft.Json;

namespace Eshop.Games.Services.Nintendo
{
    internal class NintendoJPService : BaseService, INintendoService
    {
        public NintendoJPService(System system)
        {

        }

        public async Task<NintendoGame> GetGames(int index, int limit, Order order)
        {
            var response = await HttpClient.GetAsync($"{Constants.NintendoJPUrl}/api/search/title?category=products&pf=switch&q=*&count={limit}&sort=title&direction=asc&offset={index}").ConfigureAwait(false);


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

        public Task<NintendoGameDetail> GetGameDetail(string slug)
        {
            throw new NotImplementedException();
        }

    }
}
