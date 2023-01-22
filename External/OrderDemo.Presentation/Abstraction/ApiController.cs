using Microsoft.AspNetCore.Mvc;

namespace OrderDemo.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiController : ControllerBase
{
}
