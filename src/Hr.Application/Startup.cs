using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using MediatR;
using Hr.Application.Common.Behaviors;

namespace Hr.Application;

public static class Statup
{
    public static IServiceCollection AddHrApplication(this IServiceCollection services)
    {
        Assembly assembly = typeof(Hr.Application.Statup).Assembly;

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(assembly);
        });

        // services.AddScoped(typeof(IPipelineBehavior<Features.Person.Register.Request, MediatR.Unit>), typeof(Features.Person.Register.Behavior));
        
        services.AddScoped(typeof(IPipelineBehavior<,>) ,typeof(ValidationBehavior<,>));

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
