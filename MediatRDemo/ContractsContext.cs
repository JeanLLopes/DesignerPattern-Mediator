using Microsoft.EntityFrameworkCore;

namespace MediatRDemo
{
    public class ContractsContext : DbContext
    {
        public ContractsContext(DbContextOptions<ContractsContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Test 1", LastName = "Lastname 1" },
                new Contact { Id = 2, FirstName = "Test 2", LastName = "Lastname 2" },
                new Contact { Id = 3, FirstName = "Test 3", LastName = "Lastname 3" }
            );
        }
    }
}