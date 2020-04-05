using System;
using Xunit;

namespace CodeLifter.HealthAPI.Covid19.Test
{
    public class Covid19APITest
    {
        [Fact]
        public void ReturnsNullWhenNoValidConnection()
        {
            Assert.True(true);
        }

        [Fact]
        public void ReturnsStatisticWhenGetGlobalStatisticsIsCalled()
        {

        }
    }
}
