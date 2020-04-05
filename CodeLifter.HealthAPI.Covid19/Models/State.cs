using System;
using CodeLifter.HealthAPI.Covid19.Models;
using Newtonsoft.Json;

namespace CodeLifter.HealthAPI.Covid19.Models
{
    public class State : Country
    {
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string StateName { get; set; }
    }
}
