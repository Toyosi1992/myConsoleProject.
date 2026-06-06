using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // The Employee class implements the IQuittable interface using the ':' symbol
    public class Employee : IQuittable
    {
        // Properties to store basic employee details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Fulfill the interface contract by providing the concrete implementation for Quit()
        public void Quit()
        {
            // Custom logic for when an employee invokes the Quit method
            Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has officially called the Quit() method.");
        }
    }
}