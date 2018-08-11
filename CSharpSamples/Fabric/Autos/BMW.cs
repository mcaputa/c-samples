using System;
using System.Collections.Generic;
using System.Text;

namespace Fabric.Autos
{
    using Fabric.Interfaces;

    public class BMW : IAuto
    {
        public void TurnOn()
        {
           Console.WriteLine("BMW is running");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
}
