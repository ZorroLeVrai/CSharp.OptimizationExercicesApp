using CSharp.OptimizationApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharp.OptimizationApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PrimeNumbersController : ControllerBase
{
    // GET: api/<PrimeNumbersController>
    [HttpGet]
    public string Get()
    {
        return PrimeNumbersService.GetFirstPrimeNumbers(5);
    }

    // GET api/<PrimeNumbersController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return PrimeNumbersService.GetFirstPrimeNumbers(id);
    }
}
