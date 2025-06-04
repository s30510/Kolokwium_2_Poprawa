using WebApplication1.DTOs;

namespace WebApplication1.Services;

public interface IDbService
{
    Task<GetClientInfoDto> GetClientInfoAsync(int id);
    
    Task AddNewCustomerAsync(AddCustomerDto newCustomer);
}