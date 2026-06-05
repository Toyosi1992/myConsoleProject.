using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // POLYMORPHISM IN ACTION: 
            // We create a new instance of the Employee class, but assign it to a variable 
            // whose type is declared as the interface 'IQuittable'.
            // This is valid because an Employee *is* an IQuittable entity.
            IQuittable quittableEmployee = new Employee()
            {
                Id = 101,
                FirstName = "Jane",
                LastName = "Doe"
            };

            Console.WriteLine("--- Polymorphism Test ---");

            // Call the Quit() method on our interface reference type variable.
            // At runtime, the computer looks at the actual underlying object (Employee) 
            // and executes its specific Quit() logic.
            quittableEmployee.Quit();

            // Keep the console open until the user presses Enter
            Console.WriteLine("\nAssignment complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}