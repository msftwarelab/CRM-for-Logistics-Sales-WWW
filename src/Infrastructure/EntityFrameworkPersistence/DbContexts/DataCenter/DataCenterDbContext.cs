/*
using Application.Common.Interfaces;
using FirstFreightAPI.Entities.DataCenter;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.DbContexts.DataCenter;

public class DataCenterDbContext : DbContext, IDataCenterDbContext
{
    public DataCenterDbContext()
    {
    }

    public DataCenterDbContext(DbContextOptions<DataCenterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<CalendarInvite> CalendarInvites { get; set; }

    public virtual DbSet<Commodity> Commodities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyLinkType> CompanyLinkTypes { get; set; }

    public virtual DbSet<CompanySegment> CompanySegments { get; set; }

    public virtual DbSet<CompanyType> CompanyTypes { get; set; }

    public virtual DbSet<Competitor> Competitors { get; set; }

    public virtual DbSet<Contact> Contacts => Set<Contact>();

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<DealInvite> DealInvites { get; set; }

    public virtual DbSet<DealNotification> DealNotifications { get; set; }

    public virtual DbSet<DealSalesStageHistory> DealSalesStageHistories { get; set; }

    public virtual DbSet<DealType> DealTypes { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

    public virtual DbSet<EmailAttachment> EmailAttachments { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventCompany> EventCompanies { get; set; }

    public virtual DbSet<EventContact> EventContacts { get; set; }

    public virtual DbSet<ExchangeSyncErrorLog> ExchangeSyncErrorLogs { get; set; }

    public virtual DbSet<ExchangeSyncLog> ExchangeSyncLogs { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<Lane> Lanes { get; set; }

    public virtual DbSet<LinkCalendarEventToUser> LinkCalendarEventToUsers { get; set; }

    public virtual DbSet<LinkCompanyToCompany> LinkCompanyToCompanies { get; set; }

    public virtual DbSet<LinkContactToCompany> LinkContactToCompanies { get; set; }

    public virtual DbSet<LinkContactToContact> LinkContactToContacts { get; set; }

    public virtual DbSet<LinkContactToDeal> LinkContactToDeals { get; set; }

    public virtual DbSet<LinkUserToCompany> LinkUserToCompanies { get; set; }

    public virtual DbSet<LinkUserToContact> LinkUserToContacts { get; set; }

    public virtual DbSet<LinkUserToDeal> LinkUserToDeals { get; set; }

    public virtual DbSet<LinkUserToManager> LinkUserToManagers { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LostReason> LostReasons { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Quote> Quotes { get; set; }

    public virtual DbSet<QuotePackage> QuotePackages { get; set; }

    public virtual DbSet<QuoteStatus> QuoteStatuses { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<SalesManager> SalesManagers { get; set; }

    public virtual DbSet<SalesStage> SalesStages { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<FirstFreightAPI.Entities.DataCenter.Task> Tasks { get; set; }

    public virtual DbSet<TaskCompany> TaskCompanies { get; set; }

    public virtual DbSet<TaskContact> TaskContacts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserActivationsDeactivation> UserActivationsDeactivations { get; set; }

    public virtual DbSet<UserActivity> UserActivities { get; set; }

    public virtual DbSet<WonReason> WonReasons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        DataCenterModelBuilder.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}
*/