using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquationsService : IQuadraticEquationsService
    {
       public double a, b, c;
        public double GetResult(double x1, double x2)
        {
            
            double deltaRoot = Math.Sqrt(b * b - 4 * a * c);

            if (deltaRoot >= 0)
            {
                x1 = (-b + deltaRoot) / 2 * a;
                x2 = (-b + deltaRoot) / 2 * a;
            }
            return GetResult(x1,x2);
            
        }
    }
}
