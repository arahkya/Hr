using Hr.Domains.Common.Interfaces;

namespace Hr.Domains.Features.Payroll;

public class EmployeePayroll : IEntity
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public ICollection<PayrollTransaction> Transactions { get; set; } = new List<PayrollTransaction>();
}