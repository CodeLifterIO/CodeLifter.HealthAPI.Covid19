using System;
using CodeLifter.HealthAPI.Covid19.Models;
using Xunit;

namespace CodeLifter.HealthAPI.Covid19.Test
{
    public class Covid19APITest
    {
        private ICovid19Api api { get; set; }

        public Covid19APITest()
        {
            api = new Covid19Api();
        }

        [Fact]
        public async void ReturnsStatisticWhenGetGlobalStatisticsIsCalled()
        {
            Statistic global = await api.GetGlobalStatistics();
            Assert.NotNull(global);
        }
    }
}
