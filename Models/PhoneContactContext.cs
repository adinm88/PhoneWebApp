using Microsoft.EntityFrameworkCore;

namespace PhoneWebApp.Models
{
    public class PhoneContactContext : DbContext
    {
        public PhoneContactContext(DbContextOptions<PhoneContactContext> options) : base(options)
        {
        }

        public DbSet<PhoneContact> PhoneContacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PhoneContact>().HasData(
                new PhoneContact
                {
                    ContactId = 1,
                    Name = "Alice Johnson",
                    PhoneNumber = "515-555-1234",
                    Address = "123 Maple St, Springfield, IL",
                    Note = "Friend from college"
                },
                new PhoneContact
                {
                    ContactId = 2,
                    Name = "Bob Smith",
                    PhoneNumber = "515-555-5678",
                },
                new PhoneContact
                {
                    ContactId = 3,
                    Name = "Charlie Davis",
                    PhoneNumber = "319-555-8765",
                    Note = "Work colleague"
                },
                new PhoneContact
                {
                    ContactId = 4,
                    Name = "Diana Evans",
                    PhoneNumber = "712-555-4321",
                    Address = "456 Oak Ave, Lincoln, NE"
                }
        );

        }
    }
}
