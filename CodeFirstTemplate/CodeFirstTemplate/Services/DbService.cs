using CodeFirstTemplate.Data;
using CodeFirstTemplate.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstTemplate.Services;

public class DbService : IDbService
{
    DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ExampleDto> GetExampleAsync()
    {
        var example = await _dbContext.Examples.FirstOrDefaultAsync();
        return new ExampleDto
        {
            Id = example.Id,
            Name = example.Name,
        };
    }
}