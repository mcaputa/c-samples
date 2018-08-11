using System;
using System.Collections.Generic;
using System.Text;

namespace Fabric.Autos
{
    using Fabric.Interfaces;

    public class Audi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Audi is running");
        }

        public void TurnOff()
        {
           Console.WriteLine("I turned off audi");
        }
    }
}
