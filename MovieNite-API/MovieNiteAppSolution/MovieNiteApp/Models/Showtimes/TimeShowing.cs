using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNiteApp.Models.Showtimes
{
    public class TimeShowing
    {
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }
    }
}