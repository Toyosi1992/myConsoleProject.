using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and populate its data fields
            Employee employee1 = new Employee()
            {
                Id = 505,
                FirstName = "Marcus",
                LastName = "Aurelius"
            };

            // Instantiate the second Employee object with different names but the SAME Id
            Employee employee2 = new Employee()
            {
                Id = 505,
                FirstName = "Hellen",
                LastName = "Keller"
            };

            Console.WriteLine("--- Testing Operator Overloading ---");
            Console.WriteLine($"Employee 1 ID: {employee1.Id} ({employee1.FirstName})");
            Console.WriteLine($"Employee 2 ID: {employee2.Id} ({employee2.FirstName})");
            Console.WriteLine(new string('-', 36));

            // Compare the two objects using the overloaded "==" operator
            if (employee1 == employee2)
            {
                // This block executes because their IDs match, despite having completely different names
                Console.WriteLine("Result: The employees are EQUAL (Their IDs match).");
            }
            else
            {
                Console.WriteLine("Result: The employees are NOT EQUAL.");
            }

            // Quick alternative check using the "!=" operator to ensure pair consistency
            Console.WriteLine($"\nTesting inequality (!=) check directly: {employee1 != employee2}");

            // Keep the console open until a key is pressed
            Console.WriteLine("\nAssignment complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}