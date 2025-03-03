using Expance_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expance_Tracker.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        // Define your tables (DbSet properties)
        public DbSet<ExpenceItem> Expences { get; set; }
        public DbSet<ExpenceCategory> Categories { get; set; }
    }
}
