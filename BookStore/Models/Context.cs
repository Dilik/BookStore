using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<CoverType> CoverTypes{ get; set; }

    }
}
