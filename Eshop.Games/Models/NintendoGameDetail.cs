using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class NintendoGameDetail
    {
        [JsonProperty("game")]
        public GameDetail Game { get; set; }
    }
}
