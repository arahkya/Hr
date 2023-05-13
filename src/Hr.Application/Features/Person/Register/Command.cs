using MediatR;

namespace Hr.Application.Features.Person.Register;

public class Command : IRequestHandler<Request, MediatR.Unit>
{
    public Task<Unit> Handle(Request request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Unit.Value);
    }
}