using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Liskov
    {
        public void PrintSequence<T>(IEnumerable<T> items) // Everything what correct implement IEnumerable I can pass to method and it will work correctly
        { // the result should be the same whatever implementation of IEnumerable
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
