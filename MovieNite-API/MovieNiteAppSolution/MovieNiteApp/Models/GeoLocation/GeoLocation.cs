using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.GeoLocation
{
    

    public class GeoLocation
    {
        [JsonProperty("data")]
        public IList<Data> GeoData { get; set; }

    }
}