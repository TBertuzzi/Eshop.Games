using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class GameDetail
    {
        [JsonProperty("game_overview_description")]
        internal List<object> DescriptionOverview { get; set; }

        [JsonIgnore]
        public string DescriptionHTML
        {
            get
            {
                if (DescriptionOverview != null && DescriptionOverview.Count > 0)
                {
                    return DescriptionOverview[0]?.ToString();
                }
                else
                    return "";
            }
        }

        [JsonProperty("dsiware")]
        public string Dsiware { get; set; }

        [JsonProperty("wiiware")]
        public string Wiiware { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("buyitnow")]
        public string Buyitnow { get; set; }

        [JsonProperty("threedsware")]
        public string Threedsware { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("digitaldownload")]
        public string Digitaldownload { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("disclaimers")]
        public string Disclaimers { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("demo_downloads")]
        public string DemoDownloads { get; set; }

        [JsonProperty("number_of_players")]
        public string NumberOfPlayers { get; set; }

        [JsonProperty("players_choice")]
        public string PlayersChoice { get; set; }

        [JsonProperty("buyonline")]
        public string Buyonline { get; set; }

        [JsonProperty("game_code")]
        public string GameCode { get; set; }

        [JsonProperty("wifi_compatible")]
        public string WifiCompatible { get; set; }

        [JsonProperty("amiibo_compatibility")]
        public string AmiiboCompatibility { get; set; }

        [JsonProperty("dlc")]
        public string Dlc { get; set; }

    }
}
