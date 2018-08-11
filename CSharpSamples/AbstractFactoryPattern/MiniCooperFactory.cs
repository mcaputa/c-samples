using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class MiniCooperFactory : IAutoFactory
    {
        public IAutoMobile CreateSportCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();

            return mini;
        }

        public IAutoMobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();

            mini.AddLuxuryPackage();

            return mini;
        }

        public IAutoMobile CreateEconomyCar()
        {
            var mini = new MiniCooper();

            return mini;
        }
    }
}
