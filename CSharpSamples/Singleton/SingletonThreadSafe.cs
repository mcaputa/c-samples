using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonThreadSafe
    {
        private static readonly SingletonThreadSafe instance = new SingletonThreadSafe(); //without use lock, mutex and volatile

        private SingletonThreadSafe()
        {
        }

        public static SingletonThreadSafe Instance => instance;
    
    }
}
