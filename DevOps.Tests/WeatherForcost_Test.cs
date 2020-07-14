using System;
using System.Linq;
using DevOpsDotnet.Controllers;
using Xunit;

namespace DevOps.Tests
{
    public class WeatherForcost_Test
    {
        WeatherForecastController _controller=null;
        public WeatherForcost_Test(){
         _controller = new WeatherForecastController();
        }
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GEtTemprature()
        {              
                var temps=_controller.Get();
                Assert.True(temps.ToList().Count>0);
                Assert.Equal(5,temps.ToList().Count);
        }
        

    }
}
