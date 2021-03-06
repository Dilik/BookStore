using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookStore.Models
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<CoverType> CoverTypes{ get; set; }
        public DbSet<Product> Products{ get; set; }

    }
}
