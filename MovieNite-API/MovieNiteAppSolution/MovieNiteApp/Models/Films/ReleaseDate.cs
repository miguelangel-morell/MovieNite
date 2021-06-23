using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class ReleaseDate
    {
        [JsonProperty("release_date")]
        public DateTime DateOfRelease { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}