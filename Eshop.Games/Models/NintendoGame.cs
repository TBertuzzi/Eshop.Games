using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    internal class NintendoGame
    {
        [JsonProperty("games")]
        public Games Games { get; set; }
    }
}
