using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class BMWFactory : IAutoFactory
    {
        public IAutoMobile CreateSportCar()
        {
           return new BMWSport();
        }

        public IAutoMobile CreateLuxuryCar()
        {
            return new BMWLuxury();
        }

        public IAutoMobile CreateEconomyCar()
        {
          return new BMWEconomy();
        }
    }
}
