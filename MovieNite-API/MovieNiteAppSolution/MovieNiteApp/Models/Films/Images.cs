using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class Images
    {
        [JsonProperty("poster")]
        public ImagePoster ImgPoster { get; set; }
    }
}