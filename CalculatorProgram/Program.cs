using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2,4));
            Console.WriteLine(calculator.Subtract(2,4));
            Console.WriteLine(calculator.Multiply(2,4));
            Console.WriteLine(calculator.Power(2,4));

            Console.WriteLine("Employee of the month: Kristian");

            Console.ReadKey();
        }
    }
}
