using Hr.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Hr.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddHrInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<DefaultDbContext>(opt => {
            opt.UseSqlServer("Server=dev-db;Database=HrDb;User Id=sa;Password=Password!123;TrustServerCertificate=true");
        });

        return services;
    }
}