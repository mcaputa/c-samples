using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    using System.Security.Authentication;

    public class Product
    {
        private static int[] array = { 1, 2, 3, 4, 5 };

        public int GetNumber(int index)
        {
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 4)
            {
                throw new ArgumentException();
            }

            if (index == 3)
            {
                throw new AuthenticationException();
            }

            if (index == 1)
            {
                throw new OneProductException("Just One product, ERROR");
            }

            return array[index];
        }
    }
}
