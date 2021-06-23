using MovieNiteApp.Models.Cinemas;
using MovieNiteApp.Models.Films;
using MovieNiteApp.ClientHeaders;
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
    public class FilmShowtimesController : ApiController
    {
        [HttpGet]
        public async Task<FilmShowtime> GetFilmShowtimes() 
        {
            ///?film_id=12345&date=2018-04-12&n=10
            string geoloaction = "33.4735;-81.966667";
            string deviceDateTime = "2021-06-22T23:04:07.795Z";
            HttpClient client = MovieClientHelper.AddMovieHeaders(geoloaction,deviceDateTime);
            HttpResponseMessage response = await client.GetAsync("filmShowTimes" + "/?film_id=226644" + "&date=2021-06-24" + "&n=10");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            FilmShowtime filmShowtime = JsonConvert.DeserializeObject<FilmShowtime>(responseString);
            return filmShowtime;
        }

        //[HttpGet]
        //public async Task<FilmsShowingAndComingSoon> GetFilmsShowing() 
        //{
        //    FilmsShowingAndComingSoon films = new FilmsShowingAndComingSoon();

        //    return films;
        //}

        //[HttpGet]
        //public async Task<FilmsShowingAndComingSoon> GetFilmsComingSoon()
        //{
        //    FilmsShowingAndComingSoon films = new FilmsShowingAndComingSoon();

        //    return films;
        //}

        //[HttpGet]
        //public async Task<CinemasNearby> GetCinemasNearby()
        //{
        //    CinemasNearby cinemas = new CinemasNearby();

        //    return cinemas;
        //}
    }
}