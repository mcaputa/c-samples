using System;
using System.Collections.Generic;
using System.Text;

namespace FabricMethodPattern
{
    internal class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var bmw = new BMW();
            return bmw;
        }
    }
}
