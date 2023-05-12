using Hr.Domains.Common.Interfaces;
using Hr.Domains.Common.ValueObjects;
using Hr.Domains.Features.Payroll.ValueObjects;

namespace Hr.Domains.Features.Payroll;

public class PayrollTransaction : IEntity
{
    public int Id { get; set; }
    public TransactionType Type { get; set; } = null!;
    public decimal TotalAmount { get; set; }
    public BankAccount BankAccount { get; set; } = null!;
    public DateTime BankDepositDate { get; set; }
    public DateRange PayForPeriod { get; set; } = null!;
    public ICollection<PayrollTransactionDetail> Details { get; set; } = new List<PayrollTransactionDetail>();
}