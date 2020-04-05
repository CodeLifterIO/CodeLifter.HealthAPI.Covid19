```
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.HealthAPI.Covid19;
using CodeLifter.HealthAPI.Covid19.Models;

namespace Covid19DemoApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Task t = UseCovid19API();
            t.Wait();
        }

        static Statistic GlobalStats = null;
        static List<Country> Countries = null;
        static List<State> States = null;
        static List<State> StatesByCountry = null;

        private static async Task UseCovid19API()
        {
            Covid19Api api = new Covid19Api();
            GlobalStats = await api.GetGlobalStatistics();
            Countries = await api.GetAllCountries();
            States = await api.GetAllStates();
            StatesByCountry = await api.GetStatesByCountry("us");
        }
    }
}

```