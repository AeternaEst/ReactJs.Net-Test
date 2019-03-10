using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ReactNetTest.Models.BlogPost
{
    public class Comment
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("text")]
        public string text { get; set; }
    }
}