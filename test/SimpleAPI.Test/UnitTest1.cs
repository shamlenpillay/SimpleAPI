using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get();
            Assert.Equal("Shamlen Pillay", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
