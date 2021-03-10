using Microsoft.EntityFrameworkCore;

namespace StudentApi.Data {

    public class StudentContext : DbContext {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}