using System;
using System.Collections.Generic;
using System.Text;

namespace FabricMethodPattern
{
    internal class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var miniCooper = new MiniCooper("Mini cooper S");

            return miniCooper;
        }
    }
}
