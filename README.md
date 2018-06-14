# Eshop.Games

Get data from all the games available on the nintendo eshop

Get title, description, price, release date and all available game meta data

 ###### This is the component, works on All platforms that support .NETStandard 2.0
 
 ## Current Features:
The following features are planned for our first release:

 **Systems**
 - [x] Nintendo Switch
 - [ ] Nintendo 3DS
 
 **Features**
 - [x] Get Games
 - [X] Get Game Details
 - [ ] Get Game Amiibos Info
 - [ ] Get Game Screenshots
 
  **Country services**
  
 - [x] Nintendo North America
 - [ ] Nintendo Europe
 - [ ] Nintendo Japan
 
 
 **NuGet**

|Name|Info|
| ------------------- | :------------------: |
|Eshop.Games|[![NuGet](https://img.shields.io/badge/nuget-1.0.0-blue.svg)](https://www.nuget.org/packages/Eshop.Games/1.0.0/)|

## Sample

```csharp

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
                    Order = Order.asc,
                    Sort = Sort.title,
                    Value = ""
                };


                var games = eshopService.GetGames(query).Result;

                Console.WriteLine("Games: ");
                foreach (var game in games)
                {
                    try
                    {
                        Console.WriteLine($"Game:{game.Title}");
                        var detail = eshopService.GetGameDetail(game).Result;
                        Console.WriteLine($"Detail HTML :{detail?.DescriptionHTML}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
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

```

The complete example can be downloaded [here](https://github.com/TBertuzzi/Eshop.Games/tree/master/Eshop.Games.Test)
