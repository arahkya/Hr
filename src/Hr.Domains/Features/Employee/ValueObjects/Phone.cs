using Hr.Domains.Features.Employee.Enums;

namespace Hr.Domains.Features.Employee.ValueObjects;

public class Phone
{    
    public string Number { get; set; } = string.Empty;
    public Priority Priority { get; set; }
}
