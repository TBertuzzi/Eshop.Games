using Eshop.Games.Models;
using Eshop.Games.Services;
using System;

namespace Eshop.Games.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Config config = new Config
                {
                    Region = Region.NA,
                    System = System.NintendoSwitch
                };

                EshopService eshopService = new EshopService(config);

                Query query = new Query
                {
                    Index = 0,
                    Limit = 200,
                    Order = Order.Asc,
                    Sort = Sort.Title,
                    Value = ""
                };


                var games = eshopService.GetGames(query).Result;

                Console.WriteLine("Games: ");
                foreach (var game in games)
                {
                    Console.WriteLine($"Game:{game.Title}");
                   var detail = eshopService.GetGameDetail(game).Result;
                    Console.WriteLine($"Detail:{detail?.Description[0]}");
                }

              
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
