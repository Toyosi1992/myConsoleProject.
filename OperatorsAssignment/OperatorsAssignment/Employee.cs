using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Employee
    {
        // Properties to store basic employee metrics
        // Using 'string.Empty' to avoid the common CS8618 non-nullable warning
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // OVERLOAD THE "==" OPERATOR
        // This method must be static, public, and return a boolean (true/false)
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Reference check: If both are the exact same instance in memory, or both are null, they are equal
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // Null check: If one side is null but the other isn't, they cannot be equal
            // Note: We use the 'is' keyword instead of '==' here to avoid calling this overload method infinitely
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Core Requirement: Compare the 'Id' properties of both objects
            // Returns true if IDs match; returns false if they differ
            return emp1.Id == emp2.Id;
        }

        // OVERLOAD THE "!=" OPERATOR
        // Comparison operators must be overloaded in pairs. 
        // We can easily fulfill this by reversing the result of our "==" overload.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Returns the exact opposite of the equality check
            return !(emp1 == emp2);
        }

        // Good Practice: When overriding equality operators, it's recommended to override Equals() 
        // and GetHashCode() to keep object comparisons consistent across collections like Lists or Dictionaries.
        public override bool Equals(object? obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Use the unique Id property to generate the hash code
            return this.Id.GetHashCode();
        }
    }
}