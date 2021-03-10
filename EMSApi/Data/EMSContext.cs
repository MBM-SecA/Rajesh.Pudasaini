using Microsoft.EntityFrameworkCore;
using EMSApi.Models;


namespace EMSApi.Data
{
    public class EMSContext : DbContext
    {

        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Organization> Organization { get; set; }

    }
}