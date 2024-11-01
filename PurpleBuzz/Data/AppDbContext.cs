using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Entities;
namespace PurpleBuzz.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<PricingCard> PricingCards { get; set; }
        public DbSet<Vision> Visions { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
