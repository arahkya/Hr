namespace Hr.Domains.Features.Payroll;

public class PayrollTransactionDetail
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public TransactionDetailGroup GroupId { get; set; } = null!;
}