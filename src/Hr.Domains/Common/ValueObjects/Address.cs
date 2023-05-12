namespace Hr.Domains.Common.ValueObjects;

public class Address
{
    public string Name { get; set; } = string.Empty;
    public string Line1 { get; set; } = string.Empty;
    public string Line2 { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Subdistrict { get; set; } = string.Empty;
    public string Province { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}