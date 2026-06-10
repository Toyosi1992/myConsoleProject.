using Microsoft.EntityFrameworkCore;

namespace CodeFirstStudentDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Directs EF to look for a local SQL Server instance and create "SchoolDb"
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }
    }
}