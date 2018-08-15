using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
           var facadeService = new FacadeService();
           var userTemprature = facadeService.GetTemperatureInUserCity();
        }
    }
}
