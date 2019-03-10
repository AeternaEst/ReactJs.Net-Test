using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ReactNetTest.Models.BlogPost
{
    public class BlogPost
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("comments")]
        public IEnumerable<Comment> Comments { get; set; }
    }
}