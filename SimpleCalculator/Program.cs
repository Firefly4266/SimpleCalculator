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
            string someText = "Some text";
            string someOtherText = "Some text";

            bool isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);
            string addedText = someText + " " + someOtherText + " " + "some more text";
            string formatted = string.Format("{0} {0} some more text", someText, someOtherText);
            Console.WriteLine(addedText);
            Console.WriteLine(formatted);
        }
    }
}
