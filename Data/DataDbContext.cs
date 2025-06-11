using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TinderForDogs.Models;
using TinderForDogs.Data.Configurations;

namespace TinderForDogs.Data
{
    public class DataDbContext : IdentityDbContext<User, Microsoft.AspNetCore.Identity.IdentityRole<int>, int>
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SeedDogsConfiguration());
        }

        public DataDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Swipe> Swipes { get; set; }
    }
}
