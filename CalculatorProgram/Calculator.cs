﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;
        public double Add(double a, double b)
        {
            double sum = a + b;
            Accumulator += sum;
            return sum;
        }

        public double AddTooAcumulator(double addend)
        {
            Accumulator = Accumulator + addend;
            return Accumulator;
        }


        public double Subtract(double a, double b)
        {
            double sum = a - b;
            Accumulator += sum;
            return sum;
        }

        public double SubtractFromAcumulator(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            Accumulator += sum;
            return sum;
        }

        public double MultiplyAcumulator(double multiplyer)
        {
            Accumulator = Accumulator * multiplyer;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double sum = Math.Pow(x, exp);
            Accumulator += sum;
            return sum;
        }

        public double PowerAcumulator(double exponent)
        {
            Accumulator = Math.Pow(Accumulator,exponent);
            return Accumulator;
        }


        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            double sum = dividend / divisor;
            Accumulator += sum;
            return sum;
        }

        public double DevideAcumulator(double divisor)
        {
            Accumulator = Accumulator/divisor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
