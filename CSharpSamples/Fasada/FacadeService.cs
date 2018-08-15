using Facade.SomeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
   internal class FacadeService
    {
        private readonly EnglishMetricConverter EnglishMetricConverter;
        private readonly WeatherService WeatherService;
        private readonly GeolocationService GeolocationService;

        public FacadeService()
        {
            this.EnglishMetricConverter = new EnglishMetricConverter();
            this.WeatherService = new WeatherService();
            this.GeolocationService = new GeolocationService();
        }

        public int GetTemperatureInUserCity()
        {
            var userCity = this.GeolocationService.GetUserCity();
            var temperatureInCity = this.WeatherService.GetTemperatureInCity(userCity);
            var temperatureInFahrenheit = this.EnglishMetricConverter.GetFahrenheitTemperature(temperatureInCity);

            return temperatureInFahrenheit;
        }
    }
}
