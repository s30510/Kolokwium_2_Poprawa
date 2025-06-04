using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string? PhoneNumber { get; set; }


    public ICollection<PurchasedTicket>  PurchasedTickets{ get; set; }
    
}