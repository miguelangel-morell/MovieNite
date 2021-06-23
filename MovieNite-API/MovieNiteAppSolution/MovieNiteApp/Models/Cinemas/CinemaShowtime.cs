using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Cinemas
{
    public class CinemaShowtime
	{
        [JsonProperty("cinema_id")]
        public int CinemaId { get; set; }

        [JsonProperty("cinema_name")]
        public string CinemaName { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("showings")]
        public Showtimes.Showtimes Showtimes { get; set; }
    }
}