using Microsoft.EntityFrameworkCore;

namespace Expence_Tracker.Models
{
    public class ApplicationDBcontext:DbContext
    {
        public ApplicationDBcontext(DbContextOptions options):base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
