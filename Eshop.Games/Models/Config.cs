using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class Config
    {
        public Region Region { get; set; } = Region.NA;
        public System System { get; set; } = System.NintendoSwitch;
    }
}
