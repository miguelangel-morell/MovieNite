using Newtonsoft.Json;

namespace MovieNiteApp.Models.Films
{
    public class ImagePoster
    {
        [JsonProperty("1")]
        public PosterObj Poster { get; set; }
    }
}