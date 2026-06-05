using System;

namespace MethodVoidAssignment
{
    // Define a class to hold our core application methods
    public class CalculationEngine
    {
        // Create a void method (does not return a value) that accepts two integers as parameters
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiplying it by 10)
            // Note: The result isn't returned or displayed, fulfilling the requirement
            int internalCalculation = firstNumber * 10;

            // Display the second integer directly to the screen
            Console.WriteLine($"The value of the second parameter is: {secondNumber}");
        }
    }
}
using System;

namespace MethodVoidAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the CalculationEngine class to create an object in memory
            CalculationEngine engine = new CalculationEngine();

            Console.WriteLine("--- Call 1: Positional Arguments ---");
            // Call the method normally by passing two integers in order.
            // 5 maps to 'firstNumber' (gets multiplied by 10), and 100 maps to 'secondNumber' (gets displayed).
            engine.ProcessNumbers(5, 100);


            Console.WriteLine("\n--- Call 2: Named Arguments ---");
            // Call the method by explicitly specifying the parameters by their defined names.
            // When using named arguments, the order doesn't matter! 
            // Here, we deliberately pass secondNumber first to show the flexibility of this feature.
            engine.ProcessNumbers(secondNumber: 450, firstNumber: 12);


            // Keep the console open until the user chooses to exit
            Console.WriteLine("\nAssignment complete. Press Enter to close.");
            Console.ReadLine();
        }
    }
}