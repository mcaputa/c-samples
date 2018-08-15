using System;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Adapter();

            client.RunAdapteeMethod();
        }
    }
}
