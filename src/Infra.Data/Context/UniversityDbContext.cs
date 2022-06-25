using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
        : base(options)
        {

        }
        
        public DbSet<Course> Courses { get; set; }
    }
}