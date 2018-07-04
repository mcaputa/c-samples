using System;

namespace StructAndClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Struct structure;

            structure.Address = "Poland"; // initialization without new keyword
            structure.Website = "maciejcaputa.pl";

            Console.WriteLine($"Address:{structure.Address}, Website: {structure.Website}");

            var newStructure = structure;

            newStructure.Website = "wp.pl";

            Console.WriteLine($"Struct is value type. New structure website {newStructure.Website}, old structure website {structure.Website} ");

            Console.WriteLine($"struct can implement interface. Get name by method : {structure.GetName()}");
            
            Console.ReadLine();
        }
    }
}
