using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    internal class Games
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("game")]
        public List<Game> Game { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }
    }
}
