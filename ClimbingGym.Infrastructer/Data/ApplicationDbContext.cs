using ClimbingGym.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClimbingGym.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Card> Cards { get; set; }

    }
}