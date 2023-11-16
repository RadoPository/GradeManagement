using System.Collections.Generic;
using System.Data.Entity;

namespace GradeManagement.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public SchoolContext() : base("SchoolContext")
        {
        }

        
    }
}
