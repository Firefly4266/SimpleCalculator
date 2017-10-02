using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n Greetings user, welcome to our program.");
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.Write("\n Please enter a number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("\n Please enter a second number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("\n Please enter a basic mathmatical operation: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine($"\n {result}\n");
            }
            catch (Exception ex)
            {
                //we would would want to log this message if this were a working app.
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
