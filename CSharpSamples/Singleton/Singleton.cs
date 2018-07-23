using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance; //It isn't thread safe way 

        private Singleton()
        {
        }

        public static Singleton Instance => instance ?? new Singleton();
    }
}
