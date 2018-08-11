using System;
using System.Reflection;

namespace FabricMethodPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAutomobile();

            car.TurnOn();

            car.TurnOff();
        }

        public static IAutoFactory LoadFactory()
        {
            string factoryName = "FabricMethodPattern.MiniCooperFactory";
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
