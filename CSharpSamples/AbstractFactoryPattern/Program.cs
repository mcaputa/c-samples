using System;

namespace AbstractFactoryPattern
{
    using System.Reflection;

    internal class Program
    {
        public static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();


            IAutoMobile car = autoFactory.CreateSportCar();

            car.TurnOn();
            car.TurnOff();

            car = autoFactory.CreateLuxuryCar();

            car.TurnOn();
            car.TurnOff();

            car = autoFactory.CreateEconomyCar();

        }

        private static IAutoFactory LoadFactory()
        {
            var factoryName = "AbstractFactoryPattern.";

            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
