using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static public void Main(string[] args)
        {
            //get inup from user
            string input = Console.ReadLine();

            //create a conversion variable
            int convertedInputToNumber;
            //use newly made variable in a tryparse method to convert the input to a int.
            int.TryParse(input, out convertedInputToNumber);

            //an int can be stored in a variable and the variable can be used.
            int tree = 22;
            //int result = 3 + 6 + 45 + 30 + tree;

            //this will not work, string type must be expricited converted to int type.
            //int result = 3 + 6 + 45 + 30 + tree + input;

            //with tryparse method we pass in input and send out a int reference that is set to the int variable we created,
            //which in this case is convertedInputToNumber. Then we pass convertedInputToNumber instead of input and this works.
            int result = 3 + 6 + 45 + 30 + tree + convertedInputToNumber;
        }
    }
}