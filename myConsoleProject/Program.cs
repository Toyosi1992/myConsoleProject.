using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the mandatory opening welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requirement 2: Prompt the user to input the package weight
            Console.WriteLine("Please enter the package weight:");
            // Read the user input string and convert (parse) it into an integer
            int weight = Convert.ToInt32(Console.ReadLine());

            // Requirement 3: Check if the package exceeds the maximum weight limit of 50
            if (weight > 50)
            {
                // Display the weight error message and gracefully end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exits the Main method immediately, ending the application
            }

            // Requirement 4: Prompt the user for the package width and parse to integer
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Requirement 5: Prompt the user for the package height and parse to integer
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Requirement 6: Prompt the user for the package length and parse to integer
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate the total sum of the dimensions to check against the size limit
            int dimensionTotal = width + height + length;

            // Requirement 7: Check if the sum of the dimensions is greater than 50
            if (dimensionTotal > 50)
            {
                // Display the size error message and gracefully end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exits the Main method immediately, ending the application
            }

            // Requirement 8: Calculate the shipping quote
            // First, multiply the dimensions together to get the volume (width * height * length)
            // Next, multiply that product by the weight
            // Finally, divide the total outcome by 100.0 (using a double for decimal precision)
            double quote = (width * height * length * weight) / 100.0;

            // Requirement 9 & 10: Display the calculated quote formatted as currency (:C) and say thank you
            // The ":C" format specifier automatically adds the dollar sign ($) and two decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: {quote:C}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open in debug mode until the user presses a key
            Console.ReadLine();
        }
    }
}