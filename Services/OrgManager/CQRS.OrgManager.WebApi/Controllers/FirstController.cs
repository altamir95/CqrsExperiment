using Microsoft.AspNetCore.Mvc;

namespace CQRS.OrgManager.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstController : ControllerBase
{
    private readonly ILogger<FirstController> _logger;

    public FirstController(ILogger<FirstController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        return Ok(true);
    }
}

