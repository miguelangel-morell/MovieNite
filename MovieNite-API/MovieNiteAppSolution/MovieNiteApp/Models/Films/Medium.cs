using Newtonsoft.Json;

namespace MovieNiteApp.Models.Films
{
    public class Medium
    {
        [JsonProperty("film_image")]
        public string FilmImage { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}