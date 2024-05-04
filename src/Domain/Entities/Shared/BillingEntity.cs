using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class BillingEntity
{
    public int BillingEntityId { get; set; }

    public string? Address01 { get; set; }

    public bool Billable { get; set; }

    public string? BillingCurrencyCode { get; set; }

    public string? BillingCurrencySymbol { get; set; }

    public string? BillingFrequency { get; set; }

    public decimal BillingUserRate { get; set; }

    public string? CompanyName { get; set; }

    public string? City { get; set; }

    public string? CountryName { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool DeletedBy { get; set; }

    public string? Guid { get; set; }

    public string? InvoicePrefix { get; set; }

    public int LastUpdatedBy { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public string? Phone { get; set; }

    public string? PostalCode { get; set; }

    public string? StateProvince { get; set; }

    public int SubscriberId { get; set; }

    public double WithholdingTaxPercentage { get; set; }

    public string? Address02 { get; set; }

    public string? OutputFileName { get; set; }

    public bool ShowBillingCodesOnExcelExport { get; set; }
}
