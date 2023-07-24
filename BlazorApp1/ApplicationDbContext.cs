using BudgetBook.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Entry> Entries { get; set; }

    }
}
