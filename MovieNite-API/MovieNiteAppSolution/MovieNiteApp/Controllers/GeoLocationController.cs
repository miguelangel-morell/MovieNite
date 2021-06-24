using MovieNiteApp.Models.GeoLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MovieNiteApp.Controllers
{
    public class GeoLocationController : ApiController
    {
        [HttpGet]
        public async Task<GeoLocation> GetGeoLocation() 
        {
            string countryCode  = "US";
            string stateCode    = "regions/GA";
            string cityPrefix   = "cities?namePrefix=Aug";

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://wft-geo-db.p.rapidapi.com/v1/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "756d112b3emsh9fe23ec134a97adp111edbjsn3fd37d9105b8");
            HttpResponseMessage response = await client.GetAsync("geo/countries" + "/" +countryCode + "/" + stateCode + "/" + cityPrefix);
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            GeoLocation geoLocation =  JsonConvert.DeserializeObject<GeoLocation>(responseString);
            
            return geoLocation;
        }
    }
}