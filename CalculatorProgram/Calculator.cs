using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double sum = a - b;
            return sum;
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }

        public double Power(double x, double exp)
        {
            double sum = Math.Pow(x, exp);
            return sum;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            double sum = dividend / divisor;
            return sum;
        }
    }
}
