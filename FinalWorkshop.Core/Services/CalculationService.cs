using System;

namespace FinalWorkshop.Core.Services
{
    public class CalculationService : ICalculationService
    {
         public decimal TipAmount(decimal subTotal, double generosity)
         {
            return subTotal * (decimal)(generosity / 100);
         }

        public double GetResult(double a, double b, double c)
        {
            double deltaRoot = Math.Sqrt(b * b - 4 * a * c);

            if (deltaRoot >= 0)
            {
                double x1 = (-b + deltaRoot) / 2 * a;
                double x2 = (-b + deltaRoot) / 2 * a;
            }
            return GetResult(a, b, c);
        }
    }
}
