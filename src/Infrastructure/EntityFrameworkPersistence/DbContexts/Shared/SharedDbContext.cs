using Application.Common.Interfaces;
using Domain.Entities.Shared;
using FirstFreightAPI.Entities.Shared;
using Infrastructure.EntityFrameworkPersistence.DbContexts.Shared;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.DbContexts.Shared;

public partial class SharedDbContext : DbContext, ISharedDbContext
{
    public SharedDbContext()
    {
    }

    public SharedDbContext(DbContextOptions<SharedDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivititesMember> ActivititesMembers { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<AsyncReportRequest> AsyncReportRequests { get; set; }

    public virtual DbSet<AsyncThread> AsyncThreads { get; set; }

    public virtual DbSet<BillingContact> BillingContacts { get; set; }

    public virtual DbSet<BillingEntity> BillingEntities { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<CompanyCompetitor> CompanyCompetitors { get; set; }

    public virtual DbSet<CompanyContactsImportRequest> CompanyContactsImportRequests { get; set; }

    public virtual DbSet<CompanyImportRequest> CompanyImportRequests { get; set; }

    public virtual DbSet<CompanyLane> CompanyLanes { get; set; }

    public virtual DbSet<CompanyLinkType> CompanyLinkTypes { get; set; }

    public virtual DbSet<CompanyWarehouse> CompanyWarehouses { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

    public virtual DbSet<DealExchangeRateUpdateServiceLog> DealExchangeRateUpdateServiceLogs { get; set; }

    public virtual DbSet<Document> Documents => Set<Document>();

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<ExchangeRatesLog> ExchangeRatesLogs { get; set; }

    public virtual DbSet<ExchangeServerTimezone> ExchangeServerTimezones { get; set; }

    public virtual DbSet<ExchangeSyncErrorLog> ExchangeSyncErrorLogs { get; set; }

    public virtual DbSet<ExchangeSyncLog> ExchangeSyncLogs { get; set; }

    public virtual DbSet<ForgotPasswordRequest> ForgotPasswordRequests { get; set; }

    public virtual DbSet<FreeTrialRequest> FreeTrialRequests { get; set; }

    public virtual DbSet<GlobalCompany> GlobalCompanies => Set<GlobalCompany>();

    public virtual DbSet<GlobalCompanyAccessRequest> GlobalCompanyAccessRequests { get; set; }

    public virtual DbSet<GlobalContact> GlobalContacts => Set<GlobalContact>();

    public virtual DbSet<GlobalDeal> GlobalDeals { get; set; }

    public virtual DbSet<GlobalLane> GlobalLanes { get; set; }

    public virtual DbSet<GlobalLocation> GlobalLocations { get; set; }

    public virtual DbSet<GlobalQuote> GlobalQuotes { get; set; }

    public virtual DbSet<GlobalUser> GlobalUsers => Set<GlobalUser>();

    public virtual DbSet<GlobalUserActivationsDeactivation> GlobalUserActivationsDeactivations { get; set; }

    public virtual DbSet<GlobalUserActivity> GlobalUserActivities { get; set; }

    public virtual DbSet<GoogleSyncErrorLog> GoogleSyncErrorLogs { get; set; }

    public virtual DbSet<GoogleSyncLog> GoogleSyncLogs { get; set; }

    public virtual DbSet<Incoterm> Incoterms { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceActiveUser> InvoiceActiveUsers { get; set; }

    public virtual DbSet<InvoiceContact> InvoiceContacts { get; set; }

    public virtual DbSet<InvoiceEmail> InvoiceEmails { get; set; }

    public virtual DbSet<InvoiceSent> InvoiceSents { get; set; }

    public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

    public virtual DbSet<InvoiceStatusHistory> InvoiceStatusHistories { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguagePhrase> LanguagePhrases { get; set; }

    public virtual DbSet<LanguageTranslation> LanguageTranslations { get; set; }

    public virtual DbSet<LinkActivityToDeal> LinkActivityToDeals { get; set; }

    public virtual DbSet<LinkCompanyToCompany> LinkCompanyToCompanies { get; set; }

    public virtual DbSet<LinkCountryRegion> LinkCountryRegions { get; set; }

    public virtual DbSet<LinkGlobalCompanyGlobalUser> LinkGlobalCompanyGlobalUsers { get; set; }

    public virtual DbSet<LinkGlobalContactToCompany> LinkGlobalContactToCompanies { get; set; }

    public virtual DbSet<LinkGlobalContactToDeal> LinkGlobalContactToDeals { get; set; }

    public virtual DbSet<LinkGlobalDealGlobalUser> LinkGlobalDealGlobalUsers { get; set; }

    public virtual DbSet<LinkGlobalSuscriberToSubscriber> LinkGlobalSuscriberToSubscribers { get; set; }

    public virtual DbSet<LinkGlobalUserToGlobalContact> LinkGlobalUserToGlobalContacts { get; set; }

    public virtual DbSet<LinkGlobalUserToGlobalManager> LinkGlobalUserToGlobalManagers { get; set; }

    public virtual DbSet<LinkGlobalUserToManagingCountry> LinkGlobalUserToManagingCountries { get; set; }
    public virtual DbSet<LinkSubscriberToStripeCustomer> LinkSubscriberToStripeCustomers => Set<LinkSubscriberToStripeCustomer>();

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<OutlookCategoryColor> OutlookCategoryColors { get; set; }

    public virtual DbSet<ReassignUserRequest> ReassignUserRequests { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<ReportFilter> ReportFilters { get; set; }

    public virtual DbSet<SalesTeamRole> SalesTeamRoles { get; set; }

    public virtual DbSet<Subscriber> Subscribers => Set<Subscriber>();

    public virtual DbSet<SubscriberTransfer> SubscriberTransfers { get; set; }

    public virtual DbSet<SubscriberTransferStep> SubscriberTransferSteps { get; set; }

    public virtual DbSet<SubscriberTransferStepError> SubscriberTransferStepErrors { get; set; }

    public virtual DbSet<SwitchUserRequest> SwitchUserRequests { get; set; }

    public virtual DbSet<TableStatus> TableStatuses { get; set; }

    public virtual DbSet<Text> Texts { get; set; }

    public virtual DbSet<FirstFreightAPI.Entities.Shared.TimeZone> TimeZones { get; set; }

    public virtual DbSet<TimeZonesDaylightSaving> TimeZonesDaylightSavings { get; set; }

    public virtual DbSet<UnlocoCode> UnlocoCodes { get; set; }

    public virtual DbSet<UserEmailLink> UserEmailLinks { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<WebAppError> WebAppErrors { get; set; }

    public virtual DbSet<WorkflowAccount> WorkflowAccounts { get; set; }

    public virtual DbSet<WorkflowAccountEvent> WorkflowAccountEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SharedContextModelBuilder.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}
