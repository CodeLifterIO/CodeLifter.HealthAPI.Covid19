using System;
using Newtonsoft.Json;

namespace CodeLifter.HealthAPI.Covid19.Models
{
    public class Country : Statistic
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("last_update", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdate { get; set; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }
    }
}
