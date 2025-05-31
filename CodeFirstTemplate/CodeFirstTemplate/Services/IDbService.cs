using CodeFirstTemplate.DTOs;

namespace CodeFirstTemplate.Services;

public interface IDbService
{
    public Task<ExampleDto> GetExampleAsync();
}