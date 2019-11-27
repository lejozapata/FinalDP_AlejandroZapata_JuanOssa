using System;

namespace FinalWorkshop.Core.Services
{
    public class CalculationService : ICalculationService
    {

        public double GetResultX1(double a, double b, double c, double x1)
        {
            double deltaRoot = Math.Sqrt(b * b - 4 * a * c);

            if (deltaRoot > 0)
            {
                x1 = (-b + deltaRoot) / 2 * a;

            }
            else if(deltaRoot == 0)
            {
                x1 = -b / (2 * a);
            }
            return x1;
        }

        public double GetResultX2(double a, double b, double c, double x2)
        {
            double deltaRoot = Math.Sqrt(b * b - 4 * a * c);

            if (deltaRoot >= 0)
            {
                x2 = (-b - deltaRoot) / 2 * a;
            }
            else if (deltaRoot == 0)
            {
                x2 = -b / (2 * a);
            }
            return x2;
        }
    }
}
