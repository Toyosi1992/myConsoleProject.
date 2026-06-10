using System;
using System.Linq;

namespace CodeFirstStudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Console.WriteLine("Initializing database connection...");

                // 1. Create a new Student object
                var newStudent = new Student
                {
                    FirstName = "Alex",
                    LastName = "Mercer"
                };

                // 2. Add the student to the context
                context.Students.Add(newStudent);

                // 3. Save changes physically to SQL Server
                context.SaveChanges();

                Console.WriteLine("Success! One student record has been added to SchoolDb.");

                // Optional: Query the database back out to verify it worked in the console
                var studentCheck = context.Students.FirstOrDefault();
                if (studentCheck != null)
                {
                    Console.WriteLine($"Verified Record in DB: ID {studentCheck.Id} - {studentCheck.FirstName} {studentCheck.LastName}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}