using Microsoft.EntityFrameworkCore;

namespace Expensify.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
