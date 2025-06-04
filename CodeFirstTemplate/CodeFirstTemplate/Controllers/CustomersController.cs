using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        
        IDbService _dbService;


        public CustomersController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{customerId}/purchases")]
        public async Task<IActionResult> GetCustomerPurchases(int customerId)
        {
            try
            {
                var data = await _dbService.GetClientInfoAsync(customerId);
                return Ok(data);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] AddCustomerDto addCustomerDto)
        {
            try
            {
                await _dbService.AddNewCustomerAsync(addCustomerDto);
                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
