using Hr.Domains.Features.Employee.Enums;

namespace Hr.Domains.Features.Employee.ValueObjects;

public class Position
{    
    public string Title { get; set; } = string.Empty;    
    public Employee Supervisor { get; set; } = null!;
    public Priority Priority { get; set; }
}
