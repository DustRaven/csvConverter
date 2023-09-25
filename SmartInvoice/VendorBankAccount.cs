using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;

namespace SmartInvoice;

public class VendorBankAccount
{
    [Name("id")]
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [Name("iban")]
    [JsonPropertyName("iban")]
    public string Iban { get; set; }
    [Name("vendor_id")]
    [JsonPropertyName("vendor_id")]
    public string VendorId { get; set; }
    [Name("company_id")]
    [JsonPropertyName("company_id")]
    public string CompanyId { get; set; }
    [Name("primary")]
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
}

public class VendorBankAccounts
{
    [JsonPropertyName("vendor_bank_accounts")]
    public List<VendorBankAccount> BankAccounts { get; set; }
}