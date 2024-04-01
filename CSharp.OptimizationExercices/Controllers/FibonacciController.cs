using CSharp.OptimizationApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharp.OptimizationApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FibonacciController : ControllerBase
{
    // GET: api/<FibonacciController>
    [HttpGet]
    public long Get()
    {
        return FibonacciService.GetFibonacciTerm(5);
    }

    // GET api/<FibonacciController>/5
    [HttpGet("{id}")]
    public long Get(int id)
    {
        return FibonacciService.GetFibonacciTerm(id);
    }
}
