using System;
using Newtonsoft.Json;

namespace CodeLifter.HealthAPI.Covid19.Models
{
    public class Statistic
    {
        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public long? Confirmed { get; set; }

        [JsonProperty("deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deaths { get; set; }

        [JsonProperty("recovered", NullValueHandling = NullValueHandling.Ignore)]
        public long? Recovered { get; set; }


        [JsonProperty("total_confirmed", NullValueHandling = NullValueHandling.Ignore)]
        protected long? TotalConfirmed
        {
            set
            {
                Confirmed = value;
            }
        }

        [JsonProperty("total_deaths", NullValueHandling = NullValueHandling.Ignore)]
        protected long? TotalDeaths
        {
            set
            {
                Deaths = value;
            }
        }

        [JsonProperty("total_recovered", NullValueHandling = NullValueHandling.Ignore)]
        protected long? TotalRecovered
        {
            set
            {
                Recovered = value;
            }
        }
    }
}
