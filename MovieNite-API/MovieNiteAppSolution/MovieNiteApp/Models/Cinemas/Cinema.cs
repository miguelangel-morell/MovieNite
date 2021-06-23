using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Cinemas
{
    public class Cinema
	{
        [JsonProperty("cinema_id")]
        public int CinemaId { get; set; }

        [JsonProperty("cinema_name")]
        public string CinemaName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }

        [JsonProperty("lng")]
        public string Longitude { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }
    }
}