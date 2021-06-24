using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class FilmShowtimeDetail
    {
        [JsonProperty("film_id")]
        public int FilmId { get; set; }

        [JsonProperty("imdb_id")]
        public int ImdbId { get; set; }

        [JsonProperty("imdb_title_id")]
        public string ImdbTitleId { get; set; }

        [JsonProperty("film_name")]
        public string FilmName { get; set; }

        [JsonProperty("version_type")]
        public string VersionType { get; set; }

        [JsonProperty("age_rating")]
        public IList<AgeRating> AgeRatings { get; set; }

        [JsonProperty("images")]
        public Images FilmImages { get; set; }
    }
}