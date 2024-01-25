using Microsoft.EntityFrameworkCore;
using SellYourStuff.Web.Models;

namespace SellYourStuff.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Books" },
            new Category { Id = 2, Name = "Furniture" },
            new Category { Id = 3, Name = "Electronics" },
            new Category { Id = 4, Name = "Clothes" },
            new Category { Id = 5, Name = "Toys" },
            new Category { Id = 6, Name = "Miscellaneous" }
            );
    }
}
