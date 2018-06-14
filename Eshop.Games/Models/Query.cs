using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    public class Query
    {
        public Order Order { get; set; } = Order.asc;
        public Sort Sort { get; set; } = Sort.title;
        public int Limit { get; set; } = 200;
        public int Index { get; set; } = 0;
        public string Value { get; set; } = "";
    }
}
