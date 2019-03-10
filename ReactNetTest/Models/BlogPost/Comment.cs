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
        public string Name { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}