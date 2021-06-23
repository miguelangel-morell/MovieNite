using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Cinemas
{
    public class CinemasNearby
    {
        [JsonProperty("cinemas")]
        public List<Cinema> Cinemas { get; set; }
    }
}