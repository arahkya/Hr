using FluentValidation;

namespace Hr.Application.Features.Person.Register;

public class Validator : AbstractValidator<Request>
{
    public Validator()
    {
        RuleFor(p => p.Person.Firstname).NotEmpty().MinimumLength(2).MaximumLength(50);
    }
}