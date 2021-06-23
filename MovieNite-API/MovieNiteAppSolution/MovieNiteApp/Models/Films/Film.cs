using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class Film 
    { 
    
        [JsonProperty("film_id")]
        public int FilmId { get; set; }

        [JsonProperty("imdb_id")]
        public int ImdbId { get; set; }

        [JsonProperty("imdb_title_id")]
        public int ImdbTitleId { get; set; }

        [JsonProperty("film_name")]
        public string FilmName { get; set; }

        [JsonProperty("release_dates")]
        public List<ReleaseDate> ReleaseDates { get; set; }

        [JsonProperty("age_rating")]
        public List<AgeRating> AgeRatings { get; set; }

        [JsonProperty("film_trailer")]
        public string FilmTrailer { get; set; }

        [JsonProperty("synopsis_long")]
        public string SynopsisLong { get; set; }

        [JsonProperty("images")]
        public Images FilmImages { get; set; }

    }
}