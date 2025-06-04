using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    
    
    public DbSet<Customer> Customers { get; set; }
  //  public DbSet<Ticket> Thickets { get; set; }
   // public DbSet<Concert> Concerts { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }
    public DbSet<PurchasedTicket> PurchasedTickets { get; set; }
    
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>().HasData(new List<Customer>
        {
       new Customer
       {
           id=-1,
           FirstName="John",
           LastName="Smith",
           PhoneNumber="123456789",
       },new Customer
       {
           id=-2,
           FirstName="John",
           LastName="Smith",
           PhoneNumber="123456789",
       },
       new Customer
       {
       id=-3,
       FirstName="John",
       LastName="Smith",
       PhoneNumber="123456789",
        }
        });
        
        
        modelBuilder.Entity<TicketConcert>().HasData(new List<TicketConcert>
        {
            new TicketConcert
            {
                Id=-1,
                Price=1000
            },
            new TicketConcert
            {
                Id=-2,
                Price=1000
            },
            new TicketConcert
            {
                Id=-3,
                Price=1000
            },
           

        });

        modelBuilder.Entity<PurchasedTicket>().HasData(new List<PurchasedTicket>
        {
            new PurchasedTicket
            {
                Id =-1,
                CustomerId = -1,
                TicketConcertId = -1,
                
            }

        });
    }
}