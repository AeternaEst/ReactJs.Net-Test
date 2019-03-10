using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ReactNetTest.Models.React
{
    public class ReactModel
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}