using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.SomeLibrary
{
    internal class WeatherService
    {
        public int GetTemperatureInCity(string city)
        {
            return 30;
        }
        
        public void UnnecessaryMethod()
        {
        }

        public void NextMethodWhichWeWontUse()
        {
        }
    }
}
