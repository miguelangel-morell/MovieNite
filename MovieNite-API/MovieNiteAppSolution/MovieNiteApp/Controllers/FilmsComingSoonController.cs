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
    public class FilmsComingSoonController : ApiController
    {
        [HttpGet]
        public async Task<FilmsShowingAndComingSoon> GetFilmsComingSoon(string lat, string lng)
        {
            string geolocation = "-22.0;14.0";
            string deviceDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:sssZ");
            FilmsShowingAndComingSoon filmsComingSoon;
            try
            {
                HttpClient client = MovieClientHelper.AddMovieHeaders(geolocation, deviceDateTime);
                HttpResponseMessage response = await client.GetAsync("filmsComingSoon" + "/" + "?n=15");
                response.EnsureSuccessStatusCode();
                string responseString = await response.Content.ReadAsStringAsync();
                filmsComingSoon = JsonConvert.DeserializeObject<FilmsShowingAndComingSoon>(responseString);
            }
            catch (Exception ex)
            {

                throw;
            }


            return filmsComingSoon;
        }

    }
}