using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class BMWLuxury : BMWBase, IAutoMobile
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}
