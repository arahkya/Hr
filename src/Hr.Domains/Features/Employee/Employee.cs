using Hr.Domains.Common.Interfaces;
using Hr.Domains.Common.ValueObjects;
using Hr.Domains.Features.Employee.ValueObjects;

namespace Hr.Domains.Features.Employee;

public class Employee : IEntity
{
    public int Id { get; set; }
    public string EmployeeId { get; set; } = string.Empty;
    public Person Person { get; set; } = null!;
    public DateTime JoinedDate { get; set; }
    public ICollection<Position> Positions = new List<Position>();
    public EmployeeAddress HomeAddress { get; set; } = null!;    
    public Address OfficeAddress { get; set; } = null!;
}
