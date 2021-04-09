Edit source code:No file chosen
UniversityResult.cs ×
using System;

namespace UniversityResult
{
    public class UniversityResult
    {
        static void Main ()
        {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            const string PROMPT = "Please enter the unit result code, one of 1, 2, 3, 4, 5, 6, 7:";
            const string OUT_FORMAT = "Result code {0} is classified as '{1}'.";

            Console.WriteLine( PROMPT );
            string userInput = Console.ReadLine();
            int resultCode = int.Parse( userInput );

            string description = "";

            switch (resultCode) {
                // Insert your solution here:
                // Complete the switch statement to assign the appropriate value 
                // to description.
                //
                // Do not attempt to replace the switch statement with any other
                // construct - if, while, and for are prohibited for this exercise.
            }

            // Keep the following line intact
            Console.WriteLine( OUT_FORMAT, resultCode, description );
            Console.WriteLine( "===========================" );
        }
    }
}
© 2021 - Queensland University o