using System;

namespace Exceptions
{
    using System.Security.Authentication;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            var product = new Product();

            try
            {
                //var number = product.GetNumber(-1);

                //var number = product.GetNumber(4);

                var number = product.GetNumber(3);   
                
                //var number = product.GetNumber(1);
            }
            catch (IndexOutOfRangeException e) // just for example.
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AuthenticationException exception)
            {
                Console.WriteLine("throw further");
                throw;
            }
            catch (OneProductException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("After exceptions...");

            Console.ReadLine();
        }
    }
}
