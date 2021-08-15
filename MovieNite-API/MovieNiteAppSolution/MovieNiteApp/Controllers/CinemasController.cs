using MovieNiteApp.ClientHeaders;
using MovieNiteApp.Models.Cinemas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MovieNiteApp.Controllers
{
    public class CinemasController : ApiController
    {
        [HttpGet]
        public async Task<CinemasNearby> GetCinemasNearby(string lat,string lng)
        {
           
            string deviceDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:sssZ");
            string geolocation = "-22.0;14.0";
            //HttpClient client = MovieClientHelper.AddMovieHeaders(lat + ";" + lng, deviceDateTime);
            HttpClient client = MovieClientHelper.AddMovieHeaders(geolocation, deviceDateTime);
            HttpResponseMessage response = await client.GetAsync("cinemasNearby" + "/" + "?n=5");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            CinemasNearby cinemasNearby = JsonConvert.DeserializeObject<CinemasNearby>(responseString);

            return cinemasNearby;
        }
    }
}