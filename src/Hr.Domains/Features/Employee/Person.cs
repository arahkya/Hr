using Hr.Domains.Features.Employee.Enums;
using Hr.Domains.Common.Interfaces;
using Hr.Domains.Features.Employee.ValueObjects;

namespace Hr.Domains.Features.Employee;

public class Person : IEntity
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public GovIdentity GovIdentity { get; set; } = null!;
    public Gender Gender { get; set; } = default!;
    public ICollection<Phone> Phones { get; set; } = new List<Phone>();
    public ICollection<Email> Emails { get; set; } = new List<Email>();
}
