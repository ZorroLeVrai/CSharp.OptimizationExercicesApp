using DistantWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DistantWebApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IntToBinaryController : ControllerBase
{
    // GET api/<IntToBinaryController>/5
    [HttpGet("{value}")]
    public string Get(int value)
    {
        return ConverterService.IntToBinary(value).Result;
    }

    // POST api/<IntToBinaryController>
    [HttpPost]
    public BinaryNumbers Post([FromBody] Numbers value)
    {
        if (value == null) throw new ArgumentNullException("value");

        var result = new BinaryNumbers();
        result.Values = new string[value.Values.Length];
        for (int i = 0; i<value.Values.Length; ++i)
            result.Values[i] = ConverterService.IntToBinary(value.Values[i]).Result;

        return result;
    }
}
