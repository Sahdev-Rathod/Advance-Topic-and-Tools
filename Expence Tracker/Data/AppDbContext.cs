using Expence_Tracker.Expence_Tracker;
using Microsoft.EntityFrameworkCore;

namespace Expence_Tracker
{
    public class ExpenceDbContext : DbContext
    {
        public ExpenceDbContext(DbContextOptions<ExpenceDbContext> options) : base(options)
        {
        }

        public DbSet<Expence> Expences { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique(false);
        }
    }
}
