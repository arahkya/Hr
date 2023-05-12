using Hr.Domains.Common.Interfaces;

namespace Hr.Domains.Features.Payroll;

public class TransactionDetailGroup : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}