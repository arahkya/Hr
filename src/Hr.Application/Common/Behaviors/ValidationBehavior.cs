using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Hr.Application.Common.Behaviors;

public class ValidationBehavior<Req, Res> : IPipelineBehavior<Req, Res>
    where Req : class
{
    private readonly IEnumerable<IValidator<Req>> validators;

    public ValidationBehavior(IEnumerable<IValidator<Req>> validators)
    {
        this.validators = validators;
    }

    public async Task<Res> Handle(Req request, RequestHandlerDelegate<Res> next, CancellationToken cancellationToken)
    {
        ValidationResult validateResult = validators.First().Validate(request);

        if (validateResult.IsValid)
        {
            return await next();
        }

        throw new ValidationException("Invalid request context", validateResult.Errors);
    }
}