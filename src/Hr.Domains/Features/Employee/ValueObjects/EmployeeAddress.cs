using Hr.Domains.Common.Entities;
using Hr.Domains.Common.ValueObjects;

namespace Hr.Domains.Features.Employee.ValueObjects;

public class EmployeeAddress
{
    public Address CurrentHomeAddress { get; set; } = null!;
    public Address GovRegistredAddress { get; set; } = null!;
    public bool IsSameHomeAndGovRegisAddress { get; set; }
}