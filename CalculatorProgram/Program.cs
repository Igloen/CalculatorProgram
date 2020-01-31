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

            // Try-catch sørger for, at programmet ikke lukker når der divideres med 0. 
            try
            {
                Console.WriteLine(calculator.Divide(6,0));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No result - Attempted to divide by 0.");
            }

            
            Console.ReadKey();
        }
    }
}
