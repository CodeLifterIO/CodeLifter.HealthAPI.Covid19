using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.HealthAPI.Covid19.Models;
using CodeLifter.Http;
using RestSharp;

namespace CodeLifter.HealthAPI.Covid19
{
    public interface ICovid19Api
    {
        Task<Statistic> GetGlobalStatistics();
        Task<List<State>> GetAllStates();
        Task<List<Country>> GetAllCountries();
        Task<Country> GetCountry(string countryCode);
        Task<List<State>> GetStatesByCountry(string countryCode);
    }

    public class Covid19Api : ICovid19Api
    {
        private string BaseURI { get; set; }

        public IHttpClient Client { get; set; }

        public Covid19Api()
        {
            BaseURI = "https://health-api.com/api/v1/";
            Client = new HttpClient(BaseURI);
        }

        public Covid19Api(HttpClient client)
        {
            Client = client;
        }

        public async Task<Statistic> GetGlobalStatistics()
        {
            HttpRequest request = new HttpRequest("covid-19/total");
            var response = await Client.GetFromCache<Statistic>(request, $"get-global-statistics");
            return response;
        }

        public async Task<List<State>> GetAllStates()
        {
            HttpRequest request = new HttpRequest("covid-19/all");
            var response = await Client.GetFromCache<List<State>>(request, $"get-global-states");
            return response;
        }

        public async Task<Country> GetCountry(string countryCode)
        {
            HttpRequest request = new HttpRequest($"covid-19/{countryCode}");
            var response = await Client.GetFromCache<Country>(request, $"get-data-for-country-{countryCode}");
            return response;
        }

        public async Task<List<State>> GetStatesByCountry(string countryCode)
        {
            HttpRequest request = new HttpRequest($"covid-19/{countryCode}/full");
            var response = await Client.GetFromCache<List<State>>(request, $"get-all-state-data-for-country-{countryCode}");
            return response;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            HttpRequest request = new HttpRequest("covid-19/countries");
            var response = await Client.GetFromCache<List<Country>>(request, $"get-all-countries");
            return response;
        }
    }
}
