using CodeFirstTemplate.Exceptions;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    
    DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async  Task<GetClientInfoDto> GetClientInfoAsync(int id)
    {
        var data = await _dbContext.Customers.Where(w => w.id == id).Select(s => new GetClientInfoDto
        {
            FirstName = s.FirstName,
            LastName = s.LastName,
            PhoneNumber = s.PhoneNumber,

        }).FirstOrDefaultAsync();

        if (data == null)
        {
            throw new NoFoundException();
        }

        return data;

    }

    public async Task AddNewCustomerAsync(AddCustomerDto newCustomer)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            var idExists = _dbContext.Customers.Where(w => w.id == newCustomer.Customer.IdCustomer);

            if (idExists != null)
            {
                throw new IdExistsException();
            }
            
            var customer = new Customer
            {
                id = newCustomer.Customer.IdCustomer,
                FirstName = newCustomer.Customer.FirstName,
                LastName = newCustomer.Customer.LastName,
                PhoneNumber = newCustomer.Customer.PhoneNumber,
            };

            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            throw;
        }

    }
}