namespace FinalWorkshop.Core.Services
{
    public interface ICalculationService
    {
        decimal TipAmount(decimal subTotal, double generosity);

        double GetResultX1(double a, double b, double c, double x1);

        double GetResultX2(double a, double b, double c, double x2);
    }
}
