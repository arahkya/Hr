using Hr.Domains.Features.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Hr.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "RegisterPerson")]
    public async Task<ActionResult> RegisterPersonAync(Person person)
    {
        await Task.CompletedTask;

        return Ok();
    }
}
