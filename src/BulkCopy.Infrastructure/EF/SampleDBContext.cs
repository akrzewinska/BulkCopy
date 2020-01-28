using BulkCopy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkCopy.Infrastructure.EF
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Transfer>().HasNoKey();
        }
        
        public DbSet<Domain.Models.Transfer> Transfers { get; set; }

    }
}
