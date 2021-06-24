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
        public async Task<FilmsShowingAndComingSoon> GetFilmsComingSoon()
        {
            string geoloaction = "33.4735;-81.966667";
            string deviceDateTime = "2021-06-23T22:52:52.736Z";
            
            HttpClient client = MovieClientHelper.AddMovieHeaders(geoloaction, deviceDateTime);
            HttpResponseMessage response = await client.GetAsync("filmsComingSoon" + "/" + "?n=5");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            FilmsShowingAndComingSoon filmsComingSoon = JsonConvert.DeserializeObject<FilmsShowingAndComingSoon>(responseString);

            return filmsComingSoon;
        }

    }
}