using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class TicketConcert
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }
    
   // [ForeignKey(nameof(Ticket))]
   // public int ThicketId { get; set; }
    
    //public Ticket Ticket { get; set; }
    
    
   // [ForeignKey(nameof(Concert))]
    //public int ConcertId { get; set; }
    
    //public Ticket Concert { get; set; }


    public double Price{ get; set; }
    
    
    public ICollection<PurchasedTicket>  PurchasedTickets{ get; set; }
    
    
}