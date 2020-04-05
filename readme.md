A nice easy to use C# wrapper implementation of the [Health-api.com/api](https://health-api.com/api/v1/covid-19/total) API.

The HTTP client underneath it still needs a bit of work, so for now consider this a beta, but it's pretty solid a VERY easy to use as long as you remember to async all the way to the bottom.

1 ```Covid19Api api = new Covid19Api();```
1 ```Statistic GlobalStats = await api.GetGlobalStatistics();```

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
