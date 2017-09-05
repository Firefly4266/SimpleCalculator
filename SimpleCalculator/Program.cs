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
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int number1 = int.Parse(userInput);

            Console.Write("Enter a second number: ");
            userInput = Console.ReadLine();
            int number2 = int.Parse(userInput);

            int sum = number2 + number1;
            Console.WriteLine("The sum is {0}", sum); 
        }
    }
}
