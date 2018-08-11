namespace AbstractFactoryPattern
{
    internal interface IAutoFactory
    {
        IAutoMobile CreateSportCar();

        IAutoMobile CreateLuxuryCar();

        IAutoMobile CreateEconomyCar();
    }
}