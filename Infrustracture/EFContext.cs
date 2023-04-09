using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrustracture
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salary>().ToTable("Salary");
        }
    }
}