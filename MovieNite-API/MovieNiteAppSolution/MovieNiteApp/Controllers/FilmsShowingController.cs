using MovieNiteApp.ClientHeaders;
using MovieNiteApp.Models.Films;
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
    public class FilmsShowingController : ApiController
    {
        [HttpGet]
        public async Task<FilmsShowingAndComingSoon> GetFilmsShowing(string lat, string lng)
        {
            string geolocation = "-22.0;14.0";
            string deviceDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:sssZ");

            //HttpClient client = MovieClientHelper.AddMovieHeaders(lat + ";" + lng, deviceDateTime);
            HttpClient client = MovieClientHelper.AddMovieHeaders(geolocation, deviceDateTime);
            HttpResponseMessage response = await client.GetAsync("filmsNowShowing" + "/" + "?n=5");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            FilmsShowingAndComingSoon filmsShowing = JsonConvert.DeserializeObject<FilmsShowingAndComingSoon>(responseString);
            
            return filmsShowing;
        }
    }
}