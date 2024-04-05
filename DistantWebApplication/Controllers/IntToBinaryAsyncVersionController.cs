using DistantWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DistantWebApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IntToBinaryAsyncVersionController : ControllerBase
{
    // GET api/<IntToBinaryAsyncVersionController>/5
    [HttpGet("{value}")]
    public async Task<string> GetAsync(int value)
    {
        return await ConverterAsyncVersionService.IntToBinaryAsync(value);
    }
}
