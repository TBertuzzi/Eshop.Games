using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class GameDetail
    {
        //[JsonProperty("screenshot_gallery_ref")]
        //internal Screenshot Screenshots { get; set; }

        [JsonProperty("game_overview_description")]
        public List<object> Description { get; set; }

        [JsonProperty("dsiware")]
        public string Dsiware { get; set; }

        //[JsonProperty("caretailers")]
        //public Caretailers Caretailers { get; set; }

        [JsonProperty("wiiware")]
        public string Wiiware { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("buyitnow")]
        public string Buyitnow { get; set; }

        [JsonProperty("threedsware")]
        public string Threedsware { get; set; }

        //[JsonProperty("wifi_content")]
        //public AmiiboDescriptionClass WifiContent { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("digitaldownload")]
        public string Digitaldownload { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("disclaimers")]
        public string Disclaimers { get; set; }

        //[JsonProperty("retailers")]
        //public Retailers Retailers { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        //[JsonProperty("amiibo_description")]
        //public AmiiboDescriptionClass AmiiboDescription { get; set; }

        [JsonProperty("demo_downloads")]
        public string DemoDownloads { get; set; }

        [JsonProperty("intro")]
        public List<object> Intro { get; set; }

        [JsonProperty("number_of_players")]
        public string NumberOfPlayers { get; set; }

        [JsonProperty("players_choice")]
        public string PlayersChoice { get; set; }

        //[JsonProperty("game_category_ref")]
        //public List<GameCategoryRef> GameCategoryRef { get; set; }

        [JsonProperty("buyonline")]
        public string Buyonline { get; set; }

        [JsonProperty("game_code")]
        public string GameCode { get; set; }

        //[JsonProperty("developer_ref")]
        //public DeveloperRef DeveloperRef { get; set; }

        [JsonProperty("wifi_compatible")]
        public string WifiCompatible { get; set; }

        [JsonProperty("amiibo_compatibility")]
        public string AmiiboCompatibility { get; set; }

        //[JsonProperty("special_features")]
        //public AmiiboDescriptionClass SpecialFeatures { get; set; }

        //[JsonProperty("vc")]
        //public string Vc { get; set; }

        //[JsonProperty("off_tv")]
        //public string OffTv { get; set; }

        //[JsonProperty("description")]
        //public AmiiboDescriptionClass Description { get; set; }

        //[JsonProperty("free_to_start")]
        //public string FreeToStart { get; set; }

        //[JsonProperty("title")]
        //public string Title { get; set; }

        //[JsonProperty("id")]
        //public string Id { get; set; }

        //[JsonProperty("publisher_ref")]
        //public PublisherRef PublisherRef { get; set; }

        //[JsonProperty("system_ref")]
        //public SystemRef SystemRef { get; set; }

        //[JsonProperty("ca_price")]
        //public string CaPrice { get; set; }

        //[JsonProperty("bestsellers")]
        //public string Bestsellers { get; set; }

        //[JsonProperty("nsuid")]
        //public string Nsuid { get; set; }

        //[JsonProperty("eshop_price")]
        //public string EshopPrice { get; set; }

        //[JsonProperty("gdp")]
        //public string Gdp { get; set; }

        //[JsonProperty("front_box_art")]
        //public FrontBoxArt FrontBoxArt { get; set; }

        [JsonProperty("dlc")]
        public string Dlc { get; set; }


        //[JsonProperty("esrb_content_descriptor_ref")]
        //public List<EsrbContentDescriptorRef> EsrbContentDescriptorRef { get; set; }

        //[JsonProperty("touch_generation_compatible")]
        //public string TouchGenerationCompatible { get; set; }

        //[JsonProperty("promote_registration")]
        //public string PromoteRegistration { get; set; }

        //[JsonProperty("game_content_page_scale")]
        //public string GameContentPageScale { get; set; }

        //[JsonProperty("esrb_rating_ref")]
        //public EsrbRatingRef EsrbRatingRef { get; set; }

        //[JsonProperty("demo")]
        //public string Demo { get; set; }
    }
}
