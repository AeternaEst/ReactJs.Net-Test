using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ReactNetTest.Models.Person
{
    public class PersonOverview
    {
        [JsonProperty("overviewTitle")]
        public string OverviewTitle { get; set; }

        [JsonProperty("overviewManchet")]
        public string OverviewManchet { get; set; }
    }
}