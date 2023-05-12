using Hr.Domains.Common.Entities;
using Hr.Domains.Features.Employee;
using Microsoft.EntityFrameworkCore;

namespace Hr.Infrastructure.Persistence;

public class DefaultDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = default!;
    
    public DefaultDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DefaultDbContext).Assembly);
    }
}
