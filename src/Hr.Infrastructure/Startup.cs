using Hr.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Hr.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddHrInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<DefaultDbContext>(opt => {
            opt.UseSqlServer("Server=.;Database=HrDb;User Id=sa;Password=vkiydKN8986!;TrustServerCertificate=true");
        });

        return services;
    }
}