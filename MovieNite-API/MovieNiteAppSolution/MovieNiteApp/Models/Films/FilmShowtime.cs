using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class FilmShowtime
    {
        [JsonProperty("films")]
        public FilmShowtimeDetail FilmDetail { get; set; }

        [JsonProperty("cinemas")]
        public IList<Cinemas.CinemaShowtime> Cinemas { get; set; }
    }
}