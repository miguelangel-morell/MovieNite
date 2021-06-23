using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Showtimes
{
    public class RoomShowtimes
    {
        [JsonProperty("film_id")]
        public int FilmId { get; set; }

        [JsonProperty("film_name")]
        public string FilmName { get; set; }

        [JsonProperty("times")]
        public IList<TimeShowing> Time { get; set; }
    }
}