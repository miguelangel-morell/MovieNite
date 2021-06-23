using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Showtimes
{
    public class Showtimes
    {
        [JsonProperty("Standard")]
        public RoomShowtimes Standard { get; set; }

        [JsonProperty("IMAX")]
        public RoomShowtimes IMAX { get; set; }
    }
}