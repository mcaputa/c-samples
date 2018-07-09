using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    [Serializable]
    public class OneProductException : Exception
    {
        public OneProductException()
        {
        }

        public OneProductException(string message) : base(message)
        {
            
        }
    }
}
