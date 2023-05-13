using MediatR;
using Domain = Hr.Domains.Features.Employee;

namespace Hr.Application.Features.Person.Register;

public class Request : IRequest<MediatR.Unit>
{
    public Domain.Person Person { get; set; } = null!;
}