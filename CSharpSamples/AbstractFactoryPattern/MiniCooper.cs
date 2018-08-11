using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class MiniCooper : IAutoMobile
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void AddSportPackage()
        {
        }
        
        public void AddLuxuryPackage()
        {
        }
    }
}
