using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities;

namespace RepositoryPattern
{
    public class SchoolContext : DbContext
    {
        private readonly string _connectionString;

        public SchoolContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}