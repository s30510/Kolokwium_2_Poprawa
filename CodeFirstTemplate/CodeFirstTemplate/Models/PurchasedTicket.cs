using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class PurchasedTicket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    
    
    public Customer Customer { get; set; }
    
    [ForeignKey(nameof(TicketConcert))]
    public int TicketConcertId { get; set; }
    
    
    public TicketConcert TicketConcert { get; set; }
}