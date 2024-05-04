using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int SubscriberId { get; set; }

    public int BillingEntityId { get; set; }

    public string? AddressBlock { get; set; }

    public int BillingContactId { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactFirstName { get; set; }

    public string? ContactFullName { get; set; }

    public int CreatedById { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencySymbol { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int DeletedById { get; set; }

    public string? ExcelUrl { get; set; }

    public DateTime? EndDate { get; set; }

    public double InvoiceAmount { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? InvoiceGuid { get; set; }

    public int InvoiceMonth { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceText { get; set; }

    public int InvoiceYear { get; set; }

    public DateTime? LastUpdate { get; set; }

    public double MonthlyUserFee { get; set; }

    public bool Paid { get; set; }

    public DateTime? PaidDate { get; set; }

    public string? PdfUrl { get; set; }

    public string? Phone { get; set; }

    public DateTime? StartDate { get; set; }

    public int UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public double WithholdingTaxPercentage { get; set; }

    public double WithholdingTaxAmount { get; set; }

    public int ExcelDocumentId { get; set; }

    public int PdfDocumentId { get; set; }

    public int Status { get; set; }
}
