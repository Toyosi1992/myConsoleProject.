using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Define an interface called IQuittable
    // Interfaces traditionally start with a capital 'I' in C#
    public interface IQuittable
    {
        // Define a void method declaration with no body.
        // Any class implementing this interface must provide the concrete implementation.
        void Quit();
    }
}