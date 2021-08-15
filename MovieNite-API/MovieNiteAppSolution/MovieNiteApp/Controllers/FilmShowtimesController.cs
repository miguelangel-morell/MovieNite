﻿using MovieNiteApp.Models.Cinemas;
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
        public async Task<FilmShowtime> GetFilmShowtimes(int id, string lat, string lng) 
        {
            string geolocation = "-22.0;14.0";
            string deviceDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:sssZ");
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");

            //HttpClient client = MovieClientHelper.AddMovieHeaders(lat + ";" + lng,deviceDateTime);
            HttpClient client = MovieClientHelper.AddMovieHeaders(geolocation, deviceDateTime);
            HttpResponseMessage response = await client.GetAsync("filmShowTimes" + "/?film_id=" + id + "&date=" + date + "&n=10");
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            FilmShowtime filmShowtime = JsonConvert.DeserializeObject<FilmShowtime>(responseString);
            
            return filmShowtime;
        }
    }
}