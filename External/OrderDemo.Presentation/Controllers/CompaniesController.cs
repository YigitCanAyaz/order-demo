using Microsoft.AspNetCore.Mvc;
using OrderDemo.Presentation.Abstraction;

namespace OrderDemo.Presentation.Controllers;

public class CompaniesController : ApiController
{
    [HttpGet]
    public IActionResult Get()
    {
        return NoContent();
    }
}
