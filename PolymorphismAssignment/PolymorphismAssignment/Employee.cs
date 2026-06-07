using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Employee now properly inherits from the Person base class AND implements the IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Unique property specific to the Employee class
        public int Id { get; set; }

        // Concrete implementation of the Quit() method required by IQuittable
        public void Quit()
        {
            // Leverages the inherited FirstName and LastName properties from Person
            Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has officially called the Quit() method.");
        }
    }
}