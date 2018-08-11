using System;

namespace Fabric
{
    using Fabric.Interfaces;

    public class Program
    {
        public static void Main(string[] args)
        {
            var careName = Console.ReadLine();

            AutoFactory factory = new AutoFactory();

            IAuto auto = factory.CreateInstance(careName);

            auto.TurnOn();

            auto.TurnOff();

            Console.ReadLine();
        }
    }
}
