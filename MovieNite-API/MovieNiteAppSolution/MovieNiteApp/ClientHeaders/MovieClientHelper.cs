using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Configuration;

namespace MovieNiteApp.ClientHeaders
{
    public class MovieClientHelper
    {
        public static HttpClient AddMovieHeaders(string geolocation, string deviceDateTime)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["MovieApiUrl"]);
            client.DefaultRequestHeaders.Add("client", ConfigurationManager.AppSettings["client"]);
            client.DefaultRequestHeaders.Add("x-api-key", ConfigurationManager.AppSettings["x-api-key"]);
            client.DefaultRequestHeaders.Add("authorization", ConfigurationManager.AppSettings["authorization"]);
            client.DefaultRequestHeaders.Add("territory", ConfigurationManager.AppSettings["territory"]);
            client.DefaultRequestHeaders.Add("api-version", ConfigurationManager.AppSettings["api-version"]);
            client.DefaultRequestHeaders.Add("geolocation", geolocation);
            client.DefaultRequestHeaders.Add("device-datetime", deviceDateTime);

            return client;
        }
    }
}