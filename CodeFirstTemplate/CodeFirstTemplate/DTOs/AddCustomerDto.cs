namespace WebApplication1.DTOs;

public class AddCustomerDto
{
   public CustomerDto Customer { get; set; }
}

public class CustomerDto
{
    public int IdCustomer { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}