namespace FinalWorkshop.Core.Services
{
    public interface ICalculationService
    {
        decimal TipAmount(decimal subTotal, double generosity);

        double GetResult(double a, double b, double c);
    }
}
