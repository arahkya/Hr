using Hr.Domains.Features.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hr.Infrastructure.Persistence.Configurations;

public class EmployeeConfigures : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(p => p.Id);
        builder.ToTable("Employees");
        builder.OwnsMany(p => p.WorkPeriods, cfg =>
        {
            cfg.ToTable("EmployeeWorkPeriods");
        });
        builder.OwnsOne(p => p.Person, cfg =>
        {
            cfg.ToTable("Person");
            cfg.OwnsMany(p => p.Phones);
            cfg.OwnsMany(p => p.Emails);
            cfg.OwnsOne(p => p.GovIdentity);
        });
        builder.OwnsMany(p => p.Positions, cfg =>
        {
            cfg.OwnsOne(p => p.Period);
            cfg.HasOne(p => p.Supervisor).WithMany().OnDelete(DeleteBehavior.Restrict);
        });
        builder.OwnsOne(p => p.HomeAddress, cfg =>
        {
            cfg.HasOne(p => p.CurrentHomeAddress).WithMany().OnDelete(DeleteBehavior.Restrict);
            cfg.HasOne(p => p.GovRegistredAddress).WithMany().OnDelete(DeleteBehavior.Restrict);
        });
        builder.HasOne(p => p.OfficeAddress).WithMany().OnDelete(DeleteBehavior.Restrict);
    }
}