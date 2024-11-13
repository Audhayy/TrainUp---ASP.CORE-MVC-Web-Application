using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TrainUp.Model;

namespace TrainUp.Data  // Adjust the namespace to match your project structure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets represent tables in the database
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; } // Example: if you have a User table for login/signup

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can be done here if needed
        }
    }
}
