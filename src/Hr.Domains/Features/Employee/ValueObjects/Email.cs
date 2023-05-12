using Hr.Domains.Features.Employee.Enums;

namespace Hr.Domains.Features.Employee.ValueObjects;

public class Email
{    
    public string Address { get; set; } = string.Empty;
    public Priority Priority { get; set; }
}
