using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Games.Models
{
    internal class Screenshot
    {
        //[JsonProperty("screenshot_gallery")]
        //public ScreenshotGallery ScreenshotGallery { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
