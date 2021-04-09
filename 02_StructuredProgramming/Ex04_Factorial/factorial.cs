using System;

namespace Factorial
{
    public class Factorial
    {
        static void Main ()
        {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            const string PROMPT = "Please enter the value of limit (between 1 and 27 inclusive):";
            const string OUT_FORMAT = "The factorial of {0} is {1}.";

            Console.WriteLine( PROMPT );
            string userInput = Console.ReadLine();
            decimal limit = decimal.Parse( userInput );

            decimal factorial = 1;

            // Insert your solution here.

            // Keep the following lines intact
            Console.WriteLine( OUT_FORMAT, limit, factorial );
            Console.WriteLine( "===========================" );
        }
    }
}