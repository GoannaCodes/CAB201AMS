using System;

namespace Hurricane
{
    public class Hurricane
    {
        static void Main ()
        {
            // Keep the following lines intact 
            Console.WriteLine( "===========================" );

            const string PROMPT = "Please enter the wind speed (km/h):";
            const string OUT_FORMAT = "If the wind speed is {0} then {1}.";

            Console.WriteLine( PROMPT );
            string userInput = Console.ReadLine();
            int windSpeed = int.Parse( userInput );

            string message = "";

            // Insert your solution here.

            // Keep the following lines intact
            Console.WriteLine( OUT_FORMAT, windSpeed, message );
            Console.WriteLine( "===========================" );
        }
    }
}