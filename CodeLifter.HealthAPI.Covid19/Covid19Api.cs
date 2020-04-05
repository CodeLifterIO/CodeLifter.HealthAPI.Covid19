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

        public IRestApiClient Client { get; set; }

        public Covid19Api()
        {
            BaseURI = "https://health-api.com/api/v1/";
            Client = new RestApiClient(BaseURI);
        }

        public Covid19Api(IRestApiClient client)
        {
            Client = client;
        }

        public async Task<Statistic> GetGlobalStatistics()
        {
            RestRequest request = new RestRequest("covid-19/total", RestSharp.Method.GET);
            var response = await Client.Get<Statistic>(request);
            return response;
        }

        public async Task<List<State>> GetAllStates()
        {
            RestRequest request = new RestRequest("covid-19/all", RestSharp.Method.GET);
            var response = await Client.Get<List<State>>(request);
            return response;
        }

        public async Task<Country> GetCountry(string countryCode)
        {
            RestRequest request = new RestRequest($"covid-19/{countryCode}", RestSharp.Method.GET);
            var response = await Client.Get<Country>(request);
            return response;
        }

        public async Task<List<State>> GetStatesByCountry(string countryCode)
        {
            RestRequest request = new RestRequest($"covid-19/{countryCode}/full", RestSharp.Method.GET);
            var response = await Client.Get<List<State>>(request);
            return response;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            RestRequest request = new RestRequest("covid-19/countries", RestSharp.Method.GET);
            var response = await Client.Get<List<Country>>(request);
            return response;
        }

    }
}
