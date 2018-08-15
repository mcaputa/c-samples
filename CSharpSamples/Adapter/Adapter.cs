using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : Client
    {
        Adaptee adaptee = new Adaptee();

        public override void RunAdapteeMethod()
        {
            adaptee.RunAdapteeMethod();
        }
    }
}
