namespace WebApplication1.DTOs;

public class GetClientInfoDto
{
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string? PhoneNumber{ get; set; }
    public List<PurchaseDto> Purchases{ get; set; }
    
    
}


public class PurchaseDto
{
    public DateTime Date { get; set; }
    public double Price { get; set; }
    public ThicketDto thicket { get; set; }
    public ConcertDto concert{ get; set; }
    
    
    
}

public class ThicketDto
{
    public string serialNum { get; set; }
    public int seatNum { get; set; }
}


public class ConcertDto
{
    public string name { get; set; }
    public DateTime Date { get; set; }
    
}