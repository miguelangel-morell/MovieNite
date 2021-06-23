using Newtonsoft.Json;

namespace MovieNiteApp.Models.Films
{
    public class PosterObj 
    {
        [JsonProperty("image_orientation")]
        public string ImageOrientation { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("medium")]
        public Medium Med { get; set; }
    }
}