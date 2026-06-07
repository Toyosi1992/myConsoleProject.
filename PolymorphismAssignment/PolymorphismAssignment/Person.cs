using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Define the base class (superclass) called Person
    public class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }

        // A void method that prints the full name to the console window
        public void SayName()
        {
            // Display the full name using string interpolation in the requested format
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}