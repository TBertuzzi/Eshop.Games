using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class Game
    {
        [JsonProperty("categories")]
        public List<string> Category { get; set; }
        // public GameCategories Categories { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ca_price", NullValueHandling = NullValueHandling.Ignore)]
        public string CaPrice { get; set; }

        [JsonProperty("nsuid")]
        public string Nsuid { get; set; }

        [JsonProperty("eshop_price")]
        public string EshopPrice { get; set; }

        [JsonProperty("front_box_art")]
        public string FrontBoxArt { get; set; }

        [JsonProperty("game_code")]
        public string GameCode { get; set; }

        [JsonProperty("video_link", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoLink { get; set; }

        [JsonProperty("number_of_players")]
        public string Numberofplayers { get; set; }
    }
}
