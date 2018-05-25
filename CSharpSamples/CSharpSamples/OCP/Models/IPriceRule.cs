namespace CSharpSamples.OCP.Models
{
    using CSharpSamples.POC.Models;

    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
