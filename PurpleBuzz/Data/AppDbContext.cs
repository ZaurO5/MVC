using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Entities;

namespace PurpleBuzz.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<AboutCard> AboutCards { get; set; }
        public DbSet<Contact> Contacts { get; set; }


    }
}

