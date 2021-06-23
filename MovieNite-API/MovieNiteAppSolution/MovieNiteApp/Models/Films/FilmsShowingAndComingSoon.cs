using Newtonsoft.Json;
using System.Collections.Generic;


namespace MovieNiteApp.Models.Films
{
    public class FilmsShowingAndComingSoon
    {
        [JsonProperty("films")]
        public List<Film> Films { get; set; }
    }
}