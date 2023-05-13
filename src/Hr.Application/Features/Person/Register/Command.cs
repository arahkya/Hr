using Hr.Application.Interfaces;
using MediatR;

namespace Hr.Application.Features.Person.Register;

public class Command : IRequestHandler<Request, MediatR.Unit>
{
    private readonly IApplicationDbContext appDbContext;

    public Command(IApplicationDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public async Task<MediatR.Unit> Handle(Request request, CancellationToken cancellationToken)
    {
        await appDbContext.AddAsync(request.Person);
        await appDbContext.CommitAsync();

        return Unit.Value;
    }
}