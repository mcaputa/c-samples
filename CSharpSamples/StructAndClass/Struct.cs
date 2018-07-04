using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndClass
{
    internal struct Struct : Interface // cannot inherit from class or other struct
    {
        // public Struct() - A struct cannot declare a default constructor, only with parameters
        // {
        // }

        // public string name = "Maciej";  - to initialize you need to use just const or static
        public Struct(string address, string website)
        {
            this.Address = address;
            this.Website = website;
        }

        public const string Name = "Maciej";

        public static string Surname = "Caputa";

        public string Address, Website;

        public string GetName()
        {
            return Name;
        }
    }
}
