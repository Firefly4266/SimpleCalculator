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
            Console.WriteLine("Let's demo formatting strings. Press enter to begin...");
            Console.ReadLine();
            Console.Clear();

            //DemoSubstitutionStrings();
            //LeftAlign();
            //RightAlign();
            //FormatNumericalData();
            StringFormat();
        }
        static void DemoSubstitutionStrings()
        {
            Console.WriteLine("Substitution strings are easier to read than concatination");
            Console.WriteLine("----------------------------------------------------------");

            //Get some data

            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What's your favorite color: ");
            string favoriteColor = Console.ReadLine();

            //Substitution strings are in curly braces, they always start with 0
            //Each substitution string is replaces with the values following the string
            Console.WriteLine("Hello {0}.  Your favorite color is {1}.\nI am a big fan of the name {0}.\n", 
                name, favoriteColor);

            //We pass literals or variables
            Console.WriteLine("My favorite number is {0}", 7);

            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void LeftAlign()
        {
            Console.WriteLine("Put a comma and a negitive number to the left align. ex: {0, -15}");
            Console.WriteLine("-----------------------------------------------------------------");

            string lineOutputFormat = "{0,-15} {1,-2} {2,-5}";
            Console.WriteLine(lineOutputFormat, "John Doe", "OH", "44113");
            Console.WriteLine(lineOutputFormat, "Jane Doe", "NY", "12065");
            Console.WriteLine(lineOutputFormat, "Cheech Marin", "CA", "90210");

            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void RightAlign()
        {
            Console.WriteLine("Put a comma and a positive number to the right align. ex: {1,9}");
            Console.WriteLine("---------------------------------------------------------------");

            /* Two things:
             * 1. We can store a format in a string for later
             2. We can use the : and a format code to do things like currency format*/

            string lineOutputFormat = "{0,-15} {1,9:C}";
            Console.WriteLine(lineOutputFormat, "A12345678", 5302.32);
            Console.WriteLine(lineOutputFormat, "A392848293", 27.32);

            //this one will overflow, watch what happens.
            Console.WriteLine(lineOutputFormat, "A20859329", 1232706.00);

            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void FormatNumericalData()
        {
            Console.WriteLine("The value 12345 in various formats:\n");
            Console.WriteLine("c format: {0:c}", 12345);
            Console.WriteLine("d9 format: {0:d9}", 12345);
            Console.WriteLine("f3 format: {0:f3}", 12345);
            Console.WriteLine("n format: {0:n}", 12345);

            Console.WriteLine("\n");

            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.

            Console.WriteLine("E format: {0:E}", 12345);
            Console.WriteLine("e format: {0:e}", 12345);

            Console.WriteLine("For hex we will use 99999 to get some letters.");
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        static void StringFormat()
        {
            //string.Format() allows for substitutions as well.
            //It returns a string we can store for later

            string totalLine = string.Format("Total: {0:c}", 25.39);
            Console.WriteLine(totalLine);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
