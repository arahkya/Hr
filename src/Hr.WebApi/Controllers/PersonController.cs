using Hr.Domains.Features.Employee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hr.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly IMediator mediator;

    public PersonController(ILogger<PersonController> logger, IMediator mediator)
    {
        _logger = logger;
        this.mediator = mediator;
    }

    [HttpPost(Name = "RegisterPerson")]
    public async Task<ActionResult> RegisterPersonAync(Person person)
    {
        await mediator.Send(new Hr.Application.Features.Person.Register.Request { Person = person });

        return Ok();
    }
}
