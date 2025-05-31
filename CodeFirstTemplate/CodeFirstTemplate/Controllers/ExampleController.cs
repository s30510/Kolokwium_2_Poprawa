using CodeFirstTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        
        IDbService _dbService;


        public ExampleController(IDbService dbService)
        {
            _dbService = dbService;
        }


        [HttpGet]
        public async Task<IActionResult> GetExampleAsync()
        {
            var data = await _dbService.GetExampleAsync();
            
            return Ok(data);
        }
        
    }
}
