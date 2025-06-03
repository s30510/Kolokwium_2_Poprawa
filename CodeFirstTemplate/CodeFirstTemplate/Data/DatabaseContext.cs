using CodeFirstTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstTemplate.Data;

public class DatabaseContext : DbContext
{
    
    
    public DbSet<Example> Examples { get; set; }
    
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Example>().HasData(new List<Example>
        {
            new Example {Id = 1, Name = "VisualStudio"},
            new Example {Id = 2, Name = "Apple"},
            new Example {Id = 3, Name = "Bolo"},
        });
    }
}