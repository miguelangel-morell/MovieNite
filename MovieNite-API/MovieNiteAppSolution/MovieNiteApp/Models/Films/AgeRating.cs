using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Films
{
    public class AgeRating
    {
        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("age_rating_image")]
        public string AgeRatingImage { get; set; }

        [JsonProperty("age_advisory")]
        public string AgeAdvisory { get; set; }
    }
}