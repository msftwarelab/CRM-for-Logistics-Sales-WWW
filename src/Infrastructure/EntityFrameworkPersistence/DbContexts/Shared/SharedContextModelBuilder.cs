using Domain.Entities.Shared;
using FirstFreightAPI.Entities.Shared;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFrameworkPersistence.DbContexts.Shared
{
    internal static class SharedContextModelBuilder
    {
        internal static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivititesMember>(entity =>
            {
                entity.HasKey(e => e.ActivityMemberId).HasName("PK_ActivitiesMembers");

                entity.HasIndex(e => e.ActivitiesId, "IX_ActivititesMembers_ActivityId");

                entity.HasIndex(e => e.ContactId, "IX_ActivititesMembers_ContactId");

                entity.HasIndex(e => e.Email, "IX_ActivititesMembers_Email");

                entity.HasIndex(e => e.SubscriberId, "IX_ActivititesMembers_SubscriberId");

                entity.HasIndex(e => e.UserIdGlobal, "IX_ActivititesMembers_UserIdGlobal");

                entity.HasIndex(e => new { e.UserId, e.Deleted }, "nci_wi_ActivititesMembers_5CCF269F1239B435B842295700B778D7");

                entity.HasIndex(e => new { e.UserIdGlobal, e.Deleted }, "nci_wi_ActivititesMembers_C13E92456DB2B53673DE2C49D9624834");

                entity.HasIndex(e => e.Deleted, "nci_wi_ActivititesMembers_FB61BE8B46C32FAFFE269EBC7292E6A0");

                entity.Property(e => e.AttendeeType).HasMaxLength(50);
                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.ContactSubscriberId).HasDefaultValueSql("((0))");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.InviteType).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");
                entity.Property(e => e.UserIdGlobal).HasDefaultValueSql("((0))");
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasIndex(e => e.ActivityType, "IX_Activities_ActivityType");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Activities_CompanyIdGlobal");

                entity.HasIndex(e => e.CreatedDate, "IX_Activities_CreatedDate");

                entity.HasIndex(e => e.OwnerUserIdGlobal, "IX_Activities_OwnerUserIdGlobal");

                entity.HasIndex(e => e.StartDateTime, "IX_Activities_StartDateTime");

                entity.HasIndex(e => e.SubscriberId, "IX_Activities_SubscriberId");

                entity.HasIndex(e => e.UserIdGlobal, "IX_Activities_UserIdGlobal");

                entity.HasIndex(e => e.CalendarEventId, "nci_wi_Activities_034A33AF9C941C20DC903A096A5D1BD1");

                entity.HasIndex(e => new { e.ActivityType, e.CompanyIdGlobal, e.DealIds }, "nci_wi_Activities_5EE6EC992714D949547770F0BEC2604F");

                entity.HasIndex(e => new { e.OwnerUserId, e.Deleted }, "nci_wi_Activities_9A92EBAE67E56EC9CD0DEE58DD8C8E8A");

                entity.HasIndex(e => new { e.CompanyIdGlobal, e.Completed }, "nci_wi_Activities_A786A3316486AF61B2D0AB5E8F648DBB");

                entity.HasIndex(e => new { e.GoogleSyncId, e.ReoccurrenceParentActivityId, e.ActivityId }, "nci_wi_Activities_CFEE88E841BF6436C62169C82F36B330");

                entity.HasIndex(e => e.Deleted, "nci_wi_Activities_DC83C1E827957C6F85D857CBE7D7FD57");

                entity.HasIndex(e => new { e.OwnerUserIdGlobal, e.Completed }, "nci_wi_Activities_EAC44CF7B75B04F6774309B829C6C640");

                entity.HasIndex(e => e.SubscriberId, "nci_wi_Activities_F5D8559C415D5CFCCDE6D6FA27C8E71F");

                entity.HasIndex(e => e.CreatedDate, "nci_wi_Activities_F87577D8C9538AE640A8761647FDF120");

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");
                entity.Property(e => e.ActivityType).HasMaxLength(50);
                entity.Property(e => e.AdminActiveOverideDate).HasColumnType("datetime");
                entity.Property(e => e.BusyFree).HasMaxLength(5);
                entity.Property(e => e.CampaignIds).HasMaxLength(50);
                entity.Property(e => e.CategoryColor).HasMaxLength(50);
                entity.Property(e => e.CategoryIds).HasMaxLength(50);
                entity.Property(e => e.CategoryName).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(500);
                entity.Property(e => e.Competitors).HasMaxLength(1000);
                entity.Property(e => e.ContactIds).HasMaxLength(100);
                entity.Property(e => e.ConversionCreatedDateTime).HasColumnType("datetime");
                entity.Property(e => e.ConversionUpdatedDateTime).HasColumnType("datetime");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserLocation).HasMaxLength(1000);
                entity.Property(e => e.CreatedUserName).HasMaxLength(100);
                entity.Property(e => e.DealIds).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(100);
                entity.Property(e => e.DueDate).HasColumnType("date");
                entity.Property(e => e.Duration).HasDefaultValueSql("((30))");
                entity.Property(e => e.EndDateTime).HasColumnType("datetime");
                entity.Property(e => e.EventSubject).HasMaxLength(500);
                entity.Property(e => e.EventTimeZone).HasMaxLength(100);
                entity.Property(e => e.EventType).HasMaxLength(10);
                entity.Property(e => e.ExchangeAppointmentId).HasMaxLength(400);
                entity.Property(e => e.ExchangeAppointmentItemId)
                    .HasMaxLength(1000)
                    .UseCollation("SQL_Latin1_General_CP1_CS_AS");
                entity.Property(e => e.ExchangeSyncId).HasMaxLength(400);
                entity.Property(e => e.ExchangeSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.GoogleSyncId).HasMaxLength(400);
                entity.Property(e => e.GoogleSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
                entity.Property(e => e.IsRecurring).HasDefaultValueSql("((0))");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.Location).HasMaxLength(500);
                entity.Property(e => e.NoteContent).HasMaxLength(4000);
                entity.Property(e => e.OriginSystem).HasMaxLength(100);
                entity.Property(e => e.OwnerUserName).HasMaxLength(200);
                entity.Property(e => e.Priority).HasMaxLength(100);
                entity.Property(e => e.PublicPrivate).HasMaxLength(10);
                entity.Property(e => e.ReminderDate).HasColumnType("datetime");
                entity.Property(e => e.ReminderIncrementType).HasMaxLength(25);
                entity.Property(e => e.ReminderMinutes).HasDefaultValueSql("((0))");
                entity.Property(e => e.ReminderType).HasMaxLength(10);
                entity.Property(e => e.ReminderTypes).HasMaxLength(50);
                entity.Property(e => e.ReoccurNumberOfTimes).HasDefaultValueSql("((0))");
                entity.Property(e => e.ReoccurrenceIncrement).HasDefaultValueSql("((0))");
                entity.Property(e => e.ReoccurrenceIncrementType).HasMaxLength(25);
                entity.Property(e => e.ReoccurrenceParentActivityId).HasDefaultValueSql("((0))");
                entity.Property(e => e.SalesPurpose).HasMaxLength(50);
                entity.Property(e => e.SalesStage).HasMaxLength(100);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.SourceDataCenterCalendarEventId).HasDefaultValueSql("((0))");
                entity.Property(e => e.SourceSubscriberId).HasDefaultValueSql("((0))");
                entity.Property(e => e.StartDate).HasColumnType("date");
                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
                entity.Property(e => e.Subject).HasMaxLength(500);
                entity.Property(e => e.SyncType).HasMaxLength(20);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.TaskName).HasMaxLength(500);
                entity.Property(e => e.UpdateUserName).HasMaxLength(100);
                entity.Property(e => e.UserLocation).HasMaxLength(200);
                entity.Property(e => e.UserName).HasMaxLength(100);
                entity.Property(e => e.UserTimeZone).HasMaxLength(100);
                entity.Property(e => e.UtcOffset).HasMaxLength(50);
            });

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.ToTable("AdminUser");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.EmailAddress).HasMaxLength(500);
                entity.Property(e => e.Forename).HasMaxLength(500);
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Surname).HasMaxLength(500);
            });

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.HasKey(e => e.AirportId).HasName("PK_tblAirports");

                entity.HasIndex(e => e.AirportName, "IX_Airports_AirportName");

                entity.HasIndex(e => e.CountryCode, "IX_Airports_CountryCode");

                entity.HasIndex(e => e.IataCode, "IX_Airports_IATA_Code");

                entity.Property(e => e.AirportName).HasMaxLength(100);
                entity.Property(e => e.AirportType).HasMaxLength(20);
                entity.Property(e => e.Continent).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(5);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.GpsCode).HasMaxLength(10);
                entity.Property(e => e.IataCode).HasMaxLength(5);
                entity.Property(e => e.IdentifierCode).HasMaxLength(5);
                entity.Property(e => e.IsoRegion).HasMaxLength(50);
                entity.Property(e => e.LastUpdated).HasColumnType("datetime");
                entity.Property(e => e.LocalCode).HasMaxLength(5);
                entity.Property(e => e.Municipality).HasMaxLength(100);
                entity.Property(e => e.ScheduledService).HasMaxLength(10);
                entity.Property(e => e.UrlHome).HasMaxLength(100);
                entity.Property(e => e.UrlWikipedia).HasMaxLength(100);
            });

            modelBuilder.Entity<AsyncReportRequest>(entity =>
            {
                entity.ToTable("AsyncReportRequest");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");
                entity.Property(e => e.Error).HasMaxLength(2000);
                entity.Property(e => e.ExcelFileUrl).HasMaxLength(300);
                entity.Property(e => e.JsonFileUrl).HasMaxLength(300);
                entity.Property(e => e.JsonfileBlobReference)
                    .HasMaxLength(200)
                    .HasColumnName("JSONFileBlobReference");
                entity.Property(e => e.JsonfileContainerReference)
                    .HasMaxLength(200)
                    .HasColumnName("JSONFileContainerReference");
                entity.Property(e => e.RefId).HasMaxLength(100);
                entity.Property(e => e.ReportName).HasMaxLength(300);
                entity.Property(e => e.RequestedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AsyncThread>(entity =>
            {
                entity.Property(e => e.DateTimeStart).HasColumnType("datetime");
                entity.Property(e => e.JobSubType).HasMaxLength(100);
                entity.Property(e => e.JobType).HasMaxLength(25);
                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<BillingContact>(entity =>
            {
                entity.HasKey(e => e.BillingContactId).HasName("PK_SubscriberBillingContact");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(100);
                entity.Property(e => e.DeletedByName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.EmailAddress).HasMaxLength(100);
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
                entity.Property(e => e.ToCc).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<BillingEntity>(entity =>
            {
                entity.Property(e => e.Address01).HasMaxLength(1000);
                entity.Property(e => e.Address02).HasMaxLength(1000);
                entity.Property(e => e.BillingCurrencyCode).HasMaxLength(20);
                entity.Property(e => e.BillingCurrencySymbol).HasMaxLength(20);
                entity.Property(e => e.BillingFrequency).HasMaxLength(50);
                entity.Property(e => e.BillingUserRate).HasColumnType("money");
                entity.Property(e => e.City).HasMaxLength(300);
                entity.Property(e => e.CompanyName).HasMaxLength(600);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.Guid).HasMaxLength(50);
                entity.Property(e => e.InvoicePrefix).HasMaxLength(50);
                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.OutputFileName).HasMaxLength(300);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.PostalCode).HasMaxLength(20);
                entity.Property(e => e.StateProvince).HasMaxLength(800);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId).HasName("PK_tblCampaigns");

                entity.Property(e => e.CampaignName).HasMaxLength(200);
                entity.Property(e => e.CampaignNumber).HasMaxLength(50);
                entity.Property(e => e.CampaignOwnerName).HasMaxLength(50);
                entity.Property(e => e.CampaignStatus).HasMaxLength(50);
                entity.Property(e => e.CampaignType).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.EndDate).HasColumnType("date");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.StartDate).HasColumnType("date");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyCompetitor>(entity =>
            {
                entity.HasKey(e => e.CompetitorId);

                entity.ToTable("CompanyCompetitor");

                entity.Property(e => e.BusinessDetails).HasMaxLength(2000);
                entity.Property(e => e.Competitor).HasMaxLength(500);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Mode).HasMaxLength(1000);
            });

            modelBuilder.Entity<CompanyContactsImportRequest>(entity =>
            {
                entity.ToTable("CompanyContactsImportRequest");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Guid).HasMaxLength(50);
                entity.Property(e => e.ProcessDurationMs).HasColumnName("ProcessDurationMS");
                entity.Property(e => e.RequestDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyImportRequest>(entity =>
            {
                entity.ToTable("CompanyImportRequest");

                entity.Property(e => e.Guid).HasMaxLength(50);
                entity.Property(e => e.RequestedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.UploadFileBlobReference).HasMaxLength(100);
                entity.Property(e => e.UploadFileContainerReference).HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyLane>(entity =>
            {
                entity.HasKey(e => e.CompanyLaneId).HasName("PK_tblCompanyLanes");

                entity.Property(e => e.AccountOwner).HasMaxLength(500);
                entity.Property(e => e.Competitors).HasMaxLength(2000);
                entity.Property(e => e.ConsigneeCompany).HasMaxLength(500);
                entity.Property(e => e.ContractEnd).HasColumnType("datetime");
                entity.Property(e => e.ContractStart).HasColumnType("datetime");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.CustomerName).HasMaxLength(200);
                entity.Property(e => e.DateDeleted).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DestinationCountryCode).HasMaxLength(10);
                entity.Property(e => e.DestinationCountryName).HasMaxLength(200);
                entity.Property(e => e.DestinationIataCode).HasMaxLength(10);
                entity.Property(e => e.DestinationName).HasMaxLength(200);
                entity.Property(e => e.DestinationRegionCode).HasMaxLength(20);
                entity.Property(e => e.DestinationRegionName).HasMaxLength(100);
                entity.Property(e => e.DestinationUnlocoCode).HasMaxLength(10);
                entity.Property(e => e.Incumbent).HasMaxLength(500);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Mode).HasMaxLength(50);
                entity.Property(e => e.OriginCountryCode).HasMaxLength(10);
                entity.Property(e => e.OriginCountryName).HasMaxLength(200);
                entity.Property(e => e.OriginIataCode).HasMaxLength(50);
                entity.Property(e => e.OriginName).HasMaxLength(200);
                entity.Property(e => e.OriginRegionCode).HasMaxLength(20);
                entity.Property(e => e.OriginRegionName).HasMaxLength(100);
                entity.Property(e => e.OriginUnlocoCode).HasMaxLength(50);
                entity.Property(e => e.RequiredLt).HasColumnName("RequiredLT");
                entity.Property(e => e.Rfqmonth).HasColumnName("RFQMonth");
                entity.Property(e => e.Service).HasMaxLength(200);
                entity.Property(e => e.ShipperCompany).HasMaxLength(100);
                entity.Property(e => e.TargetShippingFrequency).HasMaxLength(50);
                entity.Property(e => e.TargetVolumeUnit).HasMaxLength(50);
                entity.Property(e => e.TotalShippingFrequency).HasMaxLength(50);
                entity.Property(e => e.TotalVolumeUnit).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyLinkType>(entity =>
            {
                entity.HasKey(e => e.CompanyLinkTypeId).HasName("PK_CompanyLinkTypes_CompanyLinkTypeName");

                entity.Property(e => e.CompanyLinkTypeName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyWarehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
                entity.Property(e => e.WarehouseCategory).HasMaxLength(30);
                entity.Property(e => e.WarehouseIncumbentOrTarget).HasMaxLength(10);
                entity.Property(e => e.WarehouseLocation).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.CountryCode, "IX_Countries_CountryCode");

                entity.HasIndex(e => e.CountryName, "IX_Countries_CountryName");

                entity.Property(e => e.CountryCode).HasMaxLength(2);
                entity.Property(e => e.CountryDialingCode).HasMaxLength(4);
                entity.Property(e => e.CountryIsoCode)
                    .HasMaxLength(4)
                    .HasColumnName("Country_ISO_Code");
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.DataCenter).HasMaxLength(5);
                entity.Property(e => e.DateFormat).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocalCurrencyCode).HasMaxLength(4);
                entity.Property(e => e.RegionCode).HasMaxLength(20);
                entity.Property(e => e.RegionContinent).HasMaxLength(50);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.Timezone).HasMaxLength(50);
                entity.Property(e => e.UpdatedName).HasMaxLength(50);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId).HasName("PK_tblCurrencies");

                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.CurrencyFormat).HasMaxLength(20);
                entity.Property(e => e.CurrencyName).HasMaxLength(50);
                entity.Property(e => e.CurrencySymbol).HasMaxLength(5);
                entity.Property(e => e.SubUnitName).HasMaxLength(50);
                entity.Property(e => e.UnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<CurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => e.CurrencyExchangeRateId).HasName("PK_tblCurrencyExchangeRates");

                entity.HasIndex(e => e.CurrencyCode, "nci_wi_CurrencyExchangeRates_EDAD6F45D4D02C076C9C58D13BD92575");

                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.ExchangeDate).HasColumnType("date");
            });

            modelBuilder.Entity<DealExchangeRateUpdateServiceLog>(entity =>
            {
                entity.ToTable("DealExchangeRateUpdateServiceLog");

                entity.Property(e => e.EndDate).HasColumnType("datetime");
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasIndex(e => new { e.DocumentType, e.UserIdGlobal, e.Deleted }, "nci_wi_Documents_12BC7D2D8FF84EFB343AFB585EAF55FF");

                entity.HasIndex(e => new { e.CompanyIdGlobal, e.DocumentType, e.Deleted }, "nci_wi_Documents_AA5E7D39B0953BDDB156723EC9BBF2CA");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.DocumentBlobContainer).HasMaxLength(50);
                entity.Property(e => e.DocumentBlobReference).HasMaxLength(500);
                entity.Property(e => e.DocumentGroup).HasMaxLength(50);
                entity.Property(e => e.FileName).HasMaxLength(100);
                entity.Property(e => e.FileType).HasMaxLength(100);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.Title).HasMaxLength(300);
                entity.Property(e => e.UploadedByName).HasMaxLength(50);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_tblDocumentTypes");

                entity.Property(e => e.DocumentTypeText).HasMaxLength(50);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_Emails_CompanyId");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Emails_CompanyIdGlobal");

                entity.HasIndex(e => e.ContactId, "IX_Emails_ContactId");

                entity.HasIndex(e => e.DealId, "IX_Emails_DealId");

                entity.HasIndex(e => e.DealIdGlobal, "IX_Emails_DealIdGlobal");

                entity.HasIndex(e => e.SubscriberId, "IX_Emails_SubscriberId");

                entity.Property(e => e.CcEmailAddresses).HasMaxLength(500);
                entity.Property(e => e.DateSent).HasColumnType("datetime");
                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.EmailBodyHtml).HasColumnType("ntext");
                entity.Property(e => e.EmailBodyText).HasColumnType("ntext");
                entity.Property(e => e.EmailHeaders).HasMaxLength(500);
                entity.Property(e => e.Error).HasMaxLength(2000);
                entity.Property(e => e.FromEmailAddress).HasMaxLength(100);
                entity.Property(e => e.FromName).HasMaxLength(100);
                entity.Property(e => e.MailboxHash).HasMaxLength(50);
                entity.Property(e => e.MessageId).HasMaxLength(100);
                entity.Property(e => e.RecipientEmailAddresses).HasMaxLength(500);
                entity.Property(e => e.ReplyToEmailAddress).HasMaxLength(100);
                entity.Property(e => e.Subject).HasMaxLength(255);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.ToEmail).HasMaxLength(500);
                entity.Property(e => e.UtcSentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmailTemplateId).ValueGeneratedOnAdd();
                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<ExchangeRatesLog>(entity =>
            {
                entity.ToTable("ExchangeRatesLog");

                entity.Property(e => e.ElapsedTime).HasMaxLength(50);
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.ErrorMessage).HasColumnType("ntext");
                entity.Property(e => e.ReturnMessage).HasColumnType("ntext");
                entity.Property(e => e.RoutineName).HasMaxLength(100);
                entity.Property(e => e.RoutineType).HasMaxLength(50);
                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExchangeServerTimezone>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ExchangeServerTimeZone1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ExchangeServerTimeZone");
                entity.Property(e => e.TimeZoneDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<ExchangeSyncErrorLog>(entity =>
            {
                entity.ToTable("ExchangeSyncErrorLog");

                entity.Property(e => e.ErrorCode).HasMaxLength(50);
                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");
                entity.Property(e => e.RoutineType).HasMaxLength(100);
                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<ExchangeSyncLog>(entity =>
            {
                entity.ToTable("ExchangeSyncLog");

                entity.Property(e => e.SyncDateTime).HasColumnType("datetime");
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<ForgotPasswordRequest>(entity =>
            {
                entity.Property(e => e.DataCenter).HasMaxLength(100);
                entity.Property(e => e.EmailAddress).HasMaxLength(100);
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.IpAddress).HasMaxLength(100);
                entity.Property(e => e.RequestedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FreeTrialRequest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_FreeTrialRequets");

                entity.Property(e => e.CompanyName).HasMaxLength(500);
                entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
                entity.Property(e => e.CountryName).HasMaxLength(500);
                entity.Property(e => e.DataCenter).HasMaxLength(100);
                entity.Property(e => e.EmailAddress).HasMaxLength(200);
                entity.Property(e => e.EmailMessageId).HasMaxLength(500);
                entity.Property(e => e.FreeTrialCurrentStep)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.FullName).HasMaxLength(500);
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.IpAddress).HasMaxLength(100);
                entity.Property(e => e.RequestedDate).HasColumnType("datetime");
                entity.Property(e => e.VerifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GlobalCompany>(entity =>
            {
                entity.HasIndex(e => e.Active, "IX_GlobalCompanies_Active");

                entity.HasIndex(e => e.CompanyId, "IX_GlobalCompanies_CompanyId");

                entity.HasIndex(e => e.CompanyName, "IX_GlobalCompanies_CompanyName");

                entity.HasIndex(e => e.CountryName, "IX_GlobalCompanies_CountryName");

                entity.HasIndex(e => e.DataCenter, "IX_GlobalCompanies_DataCenter");

                entity.HasIndex(e => e.EmailAddress, "IX_GlobalCompanies_EmailAddress");

                entity.HasIndex(e => e.LastActivityDate, "IX_GlobalCompanies_LastActivityDate");

                entity.HasIndex(e => e.NextActivityDate, "IX_GlobalCompanies_NextActivityDate");

                entity.HasIndex(e => e.GlobalCompanyOwnerGlobalUserId, "IX_GlobalCompanies_OwnerGlobalUserId");

                entity.HasIndex(e => e.SalesTeam, "IX_GlobalCompanies_SalesTeam");

                entity.HasIndex(e => e.SubscriberId, "IX_GlobalCompanies_SubscriberId");

                entity.HasIndex(e => new { e.Active, e.Deleted }, "nci_wi_GlobalCompanies_10CA500D7223E2EC91B667A7C5E858F6");

                entity.HasIndex(e => new { e.Active, e.Deleted }, "nci_wi_GlobalCompanies_290F1424F11953EABF953389262563A0");

                entity.HasIndex(e => e.Deleted, "nci_wi_GlobalCompanies_48F29F86A3977830A905D27754C3583B");

                entity.HasIndex(e => new { e.Active, e.CompanyOwnerUserIdGlobal }, "nci_wi_GlobalCompanies_901C83189E4E682D3B6CCD676ACEDFF1");

                entity.HasIndex(e => new { e.SubscriberId, e.Active, e.Deleted }, "nci_wi_GlobalCompanies_C1885F9E5C5DFACE2377DD372D5C2208");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Address).HasMaxLength(500);
                entity.Property(e => e.AdminOverideActiveDate).HasColumnType("datetime");
                entity.Property(e => e.Campaigns).HasMaxLength(500);
                entity.Property(e => e.City).HasMaxLength(200);
                entity.Property(e => e.ClaimedDate).HasColumnType("datetime");
                entity.Property(e => e.ClaimedUserName).HasMaxLength(50);
                entity.Property(e => e.Comments).HasMaxLength(4000);
                entity.Property(e => e.CompanyCode).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.CompanySegmentName).HasMaxLength(50);
                entity.Property(e => e.CompanyTypes).HasMaxLength(500);
                entity.Property(e => e.Competitors).HasMaxLength(200);
                entity.Property(e => e.ConversionGlobalCompanyDataCenter).HasMaxLength(50);
                entity.Property(e => e.ConversionType).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrentYearOceanTeushare).HasColumnName("CurrentYearOceanTEUShare");
                entity.Property(e => e.CurrentYearOceanTeutotal).HasColumnName("CurrentYearOceanTEUTotal");
                entity.Property(e => e.DataCenter).HasMaxLength(50);
                entity.Property(e => e.DataCenterConversionAddedDate).HasColumnType("datetime");
                entity.Property(e => e.DataCenterConversionUpdatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DigitalAddress).HasMaxLength(700);
                entity.Property(e => e.Division).HasMaxLength(200);
                entity.Property(e => e.EmailAddress).HasMaxLength(150);
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.FirstShipmentDate).HasColumnType("datetime");
                entity.Property(e => e.GlobalCompanyOwnerGlobalUserName).HasMaxLength(100);
                entity.Property(e => e.GlobalCompanyOwnerName).HasMaxLength(100);
                entity.Property(e => e.Incoterms).HasMaxLength(50);
                entity.Property(e => e.Industries).HasMaxLength(200);
                entity.Property(e => e.Industry).HasMaxLength(50);
                entity.Property(e => e.IpAddress).HasMaxLength(50);
                entity.Property(e => e.LastActivityDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LastCreditUpdate).HasColumnType("datetime");
                entity.Property(e => e.LastShipmentDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkedUserEmails).HasMaxLength(500);
                entity.Property(e => e.LinkedUserNames).HasMaxLength(500);
                entity.Property(e => e.MajorProducts).HasMaxLength(1000);
                entity.Property(e => e.NextActivityDate).HasColumnType("datetime");
                entity.Property(e => e.NextYearOceanTeuobjective).HasColumnName("NextYearOceanTEUObjective");
                entity.Property(e => e.ParentCode).HasMaxLength(50);
                entity.Property(e => e.Phone).HasMaxLength(50);
                entity.Property(e => e.Phone2).HasMaxLength(50);
                entity.Property(e => e.PostalCode).HasMaxLength(200);
                entity.Property(e => e.SalesTeam).HasMaxLength(200);
                entity.Property(e => e.Source).HasMaxLength(50);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.StateProvince).HasMaxLength(500);
                entity.Property(e => e.Tags).HasMaxLength(500);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.Website).HasMaxLength(50);
                entity.Property(e => e.Whatsapp).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalCompanyAccessRequest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_tbl_GlobalCompanyAccessRequest");

                entity.ToTable("GlobalCompanyAccessRequest");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GlobalContact>(entity =>
            {
                entity.Property(e => e.BusinessAddress).HasMaxLength(500);
                entity.Property(e => e.BusinessCity).HasMaxLength(100);
                entity.Property(e => e.BusinessCountry).HasMaxLength(100);
                entity.Property(e => e.BusinessPhone).HasMaxLength(300);
                entity.Property(e => e.BusinessPhone2).HasMaxLength(300);
                entity.Property(e => e.BusinessPostalCode).HasMaxLength(30);
                entity.Property(e => e.BusinessStateProvince).HasMaxLength(50);
                entity.Property(e => e.CampaignName).HasMaxLength(500);
                entity.Property(e => e.ChildrenNames).HasMaxLength(200);
                entity.Property(e => e.CompanyName).HasMaxLength(150);
                entity.Property(e => e.ContactName).HasMaxLength(150);
                entity.Property(e => e.ContactSource).HasMaxLength(150);
                entity.Property(e => e.ContactType).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CustomerType).HasMaxLength(50);
                entity.Property(e => e.DecisionRole).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DigitalAddress).HasMaxLength(700);
                entity.Property(e => e.Email).HasMaxLength(1000);
                entity.Property(e => e.ExchangeContactId).HasMaxLength(200);
                entity.Property(e => e.ExchangeSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.GoogleContactId).HasMaxLength(500);
                entity.Property(e => e.GoogleSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.Hobbies).HasMaxLength(100);
                entity.Property(e => e.HomeAddress).HasMaxLength(500);
                entity.Property(e => e.HomeCity).HasMaxLength(100);
                entity.Property(e => e.HomeCountry).HasMaxLength(50);
                entity.Property(e => e.HomePhone).HasMaxLength(300);
                entity.Property(e => e.HomePostalCode).HasMaxLength(30);
                entity.Property(e => e.HomeStateProvince).HasMaxLength(50);
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.MiddleName).HasMaxLength(20);
                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(300)
                    .IsUnicode(false);
                entity.Property(e => e.NextActivityDate).HasColumnType("datetime");
                entity.Property(e => e.OriginSystem).HasMaxLength(100);
                entity.Property(e => e.PreviousEmployees).HasMaxLength(1000);
                entity.Property(e => e.RelatedContacts).HasMaxLength(500);
                entity.Property(e => e.SalesTeam).HasMaxLength(100);
                entity.Property(e => e.Salutation).HasMaxLength(100);
                entity.Property(e => e.Source).HasMaxLength(100);
                entity.Property(e => e.SpouseName).HasMaxLength(100);
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.Title).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.Website).HasMaxLength(100);
                entity.Property(e => e.Whatsapp).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalDeal>(entity =>
            {
                entity.HasKey(e => e.DealIdGlobal).HasName("PK_GlobalDeals_DealIdGlobal");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_GlobalDeals_CompanyIdGlobal");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_GlobalDeals_Company_Id_Global");

                entity.HasIndex(e => e.ContractEndDate, "IX_GlobalDeals_ContractEndDate");

                entity.HasIndex(e => e.ContractStartDate, "IX_GlobalDeals_ContractStartDate");

                entity.HasIndex(e => e.CountryName, "IX_GlobalDeals_CountryName");

                entity.HasIndex(e => e.DataCenter, "IX_GlobalDeals_DataCenter");

                entity.HasIndex(e => e.DateLost, "IX_GlobalDeals_DateLost");

                entity.HasIndex(e => e.DealOwnerIdGlobal, "IX_GlobalDeals_DealOwnerIdGlobal");

                entity.HasIndex(e => e.DealOwnerName, "IX_GlobalDeals_DealOwnerName");

                entity.HasIndex(e => e.DealOwnerUserId, "IX_GlobalDeals_DealOwnerUserId");

                entity.HasIndex(e => e.DecisionDate, "IX_GlobalDeals_DecisionDate");

                entity.HasIndex(e => e.DistrictCode, "IX_GlobalDeals_DistrictCode");

                entity.HasIndex(e => e.DistrictName, "IX_GlobalDeals_DistrictName");

                entity.HasIndex(e => e.EstimatedStartDate, "IX_GlobalDeals_EstimatedStartDate");

                entity.HasIndex(e => e.Industry, "IX_GlobalDeals_Industry");

                entity.HasIndex(e => e.LastActivityDate, "IX_GlobalDeals_LastActivityDate");

                entity.HasIndex(e => e.LocationCode, "IX_GlobalDeals_LocationCode");

                entity.HasIndex(e => e.LocationName, "IX_GlobalDeals_LocationName");

                entity.HasIndex(e => e.NextActivityDate, "IX_GlobalDeals_NextActivityDate");

                entity.HasIndex(e => e.RegionCode, "IX_GlobalDeals_RegionCode");

                entity.HasIndex(e => e.RegionName, "IX_GlobalDeals_RegionName");

                entity.HasIndex(e => e.SalesStageName, "IX_GlobalDeals_SalesStageName");

                entity.HasIndex(e => e.SubscriberId, "IX_GlobalDeals_SubscriberId");

                entity.HasIndex(e => new { e.Deleted, e.SalesStageName, e.CompanyIdGlobal }, "nci_wi_GlobalDeals_657E462AACFA95127F6F30B78A435768");

                entity.HasIndex(e => new { e.DealId, e.SubscriberId }, "nci_wi_GlobalDeals_6C599615C8130DBA7C8610E563FBABC0");

                entity.Property(e => e.Campaign).HasMaxLength(500);
                entity.Property(e => e.Cbms).HasColumnName("CBMs");
                entity.Property(e => e.CbmsSpot).HasColumnName("CBMsSpot");
                entity.Property(e => e.CommissionStartDate).HasColumnType("datetime");
                entity.Property(e => e.CommissionType).HasMaxLength(20);
                entity.Property(e => e.Commodities).HasMaxLength(1000);
                entity.Property(e => e.CompanyName).HasMaxLength(500);
                entity.Property(e => e.Competitors).HasMaxLength(500);
                entity.Property(e => e.ConsigneeNames).HasMaxLength(3000);
                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");
                entity.Property(e => e.ContractStartDate).HasColumnType("datetime");
                entity.Property(e => e.ConversionGlobalDealDataCenter).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(5);
                entity.Property(e => e.CountryName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(100);
                entity.Property(e => e.DataCenter).HasMaxLength(10);
                entity.Property(e => e.DateLost).HasColumnType("datetime");
                entity.Property(e => e.DateProposalDue).HasColumnType("datetime");
                entity.Property(e => e.DateWon).HasColumnType("datetime");
                entity.Property(e => e.DealCountryName).HasMaxLength(100);
                entity.Property(e => e.DealDescription).HasMaxLength(4000);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DealNumber).HasMaxLength(50);
                entity.Property(e => e.DealOwnerName).HasMaxLength(200);
                entity.Property(e => e.DealSource).HasMaxLength(200);
                entity.Property(e => e.DealType).HasMaxLength(50);
                entity.Property(e => e.DecisionDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DestinationCountries).HasMaxLength(3000);
                entity.Property(e => e.DestinationLocations).HasMaxLength(3000);
                entity.Property(e => e.DestinationRegions).HasMaxLength(3000);
                entity.Property(e => e.DistrictCode).HasMaxLength(10);
                entity.Property(e => e.DistrictName).HasMaxLength(200);
                entity.Property(e => e.EstimatedStartDate).HasColumnType("datetime");
                entity.Property(e => e.Feus).HasColumnName("FEUs");
                entity.Property(e => e.FeusSpot).HasColumnName("FEUsSpot");
                entity.Property(e => e.Incoterms).HasMaxLength(3000);
                entity.Property(e => e.Industry).HasMaxLength(200);
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastExchangeRateAppliedDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(50);
                entity.Property(e => e.NextActivityDate).HasColumnType("datetime");
                entity.Property(e => e.OrignCountries).HasMaxLength(3000);
                entity.Property(e => e.OrignLocations).HasMaxLength(3000);
                entity.Property(e => e.OrignRegions).HasMaxLength(3000);
                entity.Property(e => e.PrimaryContactName).HasMaxLength(200);
                entity.Property(e => e.ProfitUsd).HasColumnName("ProfitUSD");
                entity.Property(e => e.ProfitUsdspot).HasColumnName("ProfitUSDSpot");
                entity.Property(e => e.ReasonWonLost).HasMaxLength(50);
                entity.Property(e => e.RegionCode).HasMaxLength(10);
                entity.Property(e => e.RegionName).HasMaxLength(200);
                entity.Property(e => e.RevenueUsd).HasColumnName("RevenueUSD");
                entity.Property(e => e.RevenueUsdspot).HasColumnName("RevenueUSDSpot");
                entity.Property(e => e.SalesStageName).HasMaxLength(50);
                entity.Property(e => e.SalesTeam).HasMaxLength(500);
                entity.Property(e => e.Services).HasMaxLength(500);
                entity.Property(e => e.ShipperNames).HasMaxLength(3000);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.Teus).HasColumnName("TEUs");
                entity.Property(e => e.TeusSpot).HasColumnName("TEUsSpot");
                entity.Property(e => e.TransferredDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(200);
            });

            modelBuilder.Entity<GlobalLane>(entity =>
            {
                entity.HasKey(e => e.LaneId).HasName("PK_tblDealGlobalLanes");

                entity.Property(e => e.LaneId).ValueGeneratedNever();
                entity.Property(e => e.ConsigneeCompany).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.DateDeleted).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DestinationCountryCode).HasMaxLength(10);
                entity.Property(e => e.DestinationCountryName).HasMaxLength(200);
                entity.Property(e => e.DestinationIataCode).HasMaxLength(10);
                entity.Property(e => e.DestinationName).HasMaxLength(200);
                entity.Property(e => e.DestinationRegionCode).HasMaxLength(20);
                entity.Property(e => e.DestinationRegionName).HasMaxLength(100);
                entity.Property(e => e.DestinationUnlocoCode).HasMaxLength(10);
                entity.Property(e => e.GlobalLaneId).ValueGeneratedOnAdd();
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Mode).HasMaxLength(50);
                entity.Property(e => e.OriginCountryCode).HasMaxLength(10);
                entity.Property(e => e.OriginCountryName).HasMaxLength(200);
                entity.Property(e => e.OriginIataCode).HasMaxLength(50);
                entity.Property(e => e.OriginName).HasMaxLength(200);
                entity.Property(e => e.OriginRegionCode).HasMaxLength(20);
                entity.Property(e => e.OriginRegionName).HasMaxLength(100);
                entity.Property(e => e.OriginUnlocoCode).HasMaxLength(50);
                entity.Property(e => e.PartnerAtDestination).HasMaxLength(100);
                entity.Property(e => e.PartnerAtOrigin).HasMaxLength(100);
                entity.Property(e => e.PartnerDestinationCity).HasMaxLength(100);
                entity.Property(e => e.PartnerDestinationCode).HasMaxLength(20);
                entity.Property(e => e.PartnerDestinationContact).HasMaxLength(100);
                entity.Property(e => e.PartnerDestinationCountryCode).HasMaxLength(50);
                entity.Property(e => e.PartnerDestinationEmail).HasMaxLength(50);
                entity.Property(e => e.PartnerDestinationName).HasMaxLength(100);
                entity.Property(e => e.PartnerDestinationNameOther).HasMaxLength(100);
                entity.Property(e => e.PartnerDestinationPhone).HasMaxLength(50);
                entity.Property(e => e.PartnerOriginCity).HasMaxLength(100);
                entity.Property(e => e.PartnerOriginCode).HasMaxLength(20);
                entity.Property(e => e.PartnerOriginContact).HasMaxLength(100);
                entity.Property(e => e.PartnerOriginCountryCode).HasMaxLength(50);
                entity.Property(e => e.PartnerOriginEmail).HasMaxLength(50);
                entity.Property(e => e.PartnerOriginName).HasMaxLength(100);
                entity.Property(e => e.PartnerOriginNameOther).HasMaxLength(100);
                entity.Property(e => e.PartnerOriginPhone).HasMaxLength(50);
                entity.Property(e => e.ProfitAmount).HasDefaultValueSql("((0.0))");
                entity.Property(e => e.ProfitUnitOfMeasure).HasMaxLength(50);
                entity.Property(e => e.ReceiveFrom3Pl)
                    .HasMaxLength(500)
                    .HasColumnName("ReceiveFrom3PL");
                entity.Property(e => e.RevenueUsd).HasColumnName("RevenueUSD");
                entity.Property(e => e.Service).HasMaxLength(200);
                entity.Property(e => e.ServiceLocation).HasMaxLength(100);
                entity.Property(e => e.ShipperCompany).HasMaxLength(100);
                entity.Property(e => e.ShippingFrequency).HasMaxLength(50);
                entity.Property(e => e.SpecialRequirements).HasMaxLength(100);
                entity.Property(e => e.TotalLaneProfitUsd).HasColumnName("TotalLaneProfitUSD");
                entity.Property(e => e.TransferredDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.VolumeUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalLocation>(entity =>
            {
                entity.HasIndex(e => e.CountryCode, "IX_GlobalLocations_CountryCode");

                entity.HasIndex(e => e.CountryName, "IX_GlobalLocations_CountryName");

                entity.HasIndex(e => e.LocationCode, "IX_GlobalLocations_LocationCode");

                entity.HasIndex(e => e.LocationName, "IX_GlobalLocations_LocationName");

                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.IataCode).HasMaxLength(5);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(10);
                entity.Property(e => e.LocationName).HasMaxLength(100);
                entity.Property(e => e.UnlocoCode).HasMaxLength(20);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalQuote>(entity =>
            {
                entity.HasKey(e => e.QuoteIdGlobal);

                entity.Property(e => e.CompanyName).HasMaxLength(50);
                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.DealName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.OwnerUserName).HasMaxLength(50);
                entity.Property(e => e.QuoteAmount).HasColumnType("money");
                entity.Property(e => e.QuoteCode).HasMaxLength(50);
                entity.Property(e => e.QuoteMode).HasMaxLength(50);
                entity.Property(e => e.QuoteName).HasMaxLength(50);
                entity.Property(e => e.QuoteStatus).HasMaxLength(50);
                entity.Property(e => e.QuoteValidFrom).HasColumnType("datetime");
                entity.Property(e => e.QuoteValidTo).HasColumnType("datetime");
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalUser>(entity =>
            {
                entity.HasIndex(e => new { e.LoginEnabled, e.SubscriberId, e.CountryName, e.Deleted }, "nci_wi_GlobalUsers_D0465F9776D4D05E984BA01FDBE215EB");

                entity.Property(e => e.Address).HasMaxLength(500);
                entity.Property(e => e.AppCenter).HasMaxLength(50);
                entity.Property(e => e.BillingCode).HasMaxLength(50);
                entity.Property(e => e.BrowserName).HasMaxLength(50);
                entity.Property(e => e.BrowserVersion).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.CurrencySymbol).HasMaxLength(5);
                entity.Property(e => e.DataCenter).HasMaxLength(50);
                entity.Property(e => e.DateFormat).HasMaxLength(30);
                entity.Property(e => e.DateFormatReports).HasMaxLength(30);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.DisplayLanguage).HasMaxLength(50);
                entity.Property(e => e.DistrictCode).HasMaxLength(20);
                entity.Property(e => e.DistrictName).HasMaxLength(50);
                entity.Property(e => e.EmailAddress).HasMaxLength(150);
                entity.Property(e => e.EmailDigest).HasMaxLength(20);
                entity.Property(e => e.EmailSummaryLastSent).HasColumnType("datetime");
                entity.Property(e => e.EnableO365sync).HasColumnName("EnableO365Sync");
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.FullName).HasMaxLength(100);
                entity.Property(e => e.GoogleCalendarEmail).HasMaxLength(100);
                entity.Property(e => e.GoogleRefreshToken).HasMaxLength(1000);
                entity.Property(e => e.GoogleSyncToken).HasMaxLength(1000);
                entity.Property(e => e.IpAddress).HasMaxLength(50);
                entity.Property(e => e.LanguageCode).HasMaxLength(5);
                entity.Property(e => e.LanguageName).HasMaxLength(50);
                entity.Property(e => e.LanguagesSpoken).HasMaxLength(150);
                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(100);
                entity.Property(e => e.MobilePhone).HasMaxLength(30);
                entity.Property(e => e.Password).HasMaxLength(500);
                entity.Property(e => e.PasswordHashed).HasMaxLength(500);
                entity.Property(e => e.Phone).HasMaxLength(30);
                entity.Property(e => e.Phone2).HasMaxLength(30);
                entity.Property(e => e.PhoneExtension).HasMaxLength(10);
                entity.Property(e => e.PostalCode).HasMaxLength(20);
                entity.Property(e => e.ProfilePicture).HasMaxLength(50);
                entity.Property(e => e.RegionCode).HasMaxLength(20);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.ScreenResolution).HasMaxLength(50);
                entity.Property(e => e.SignatureImage).HasMaxLength(100);
                entity.Property(e => e.SignatureText).HasMaxLength(4000);
                entity.Property(e => e.StateProvince).HasMaxLength(50);
                entity.Property(e => e.SubscriberName).HasMaxLength(1000);
                entity.Property(e => e.SyncAppointmentsLastDateTime).HasColumnType("datetime");
                entity.Property(e => e.SyncContactsLastDateTime).HasColumnType("datetime");
                entity.Property(e => e.SyncEmail).HasMaxLength(50);
                entity.Property(e => e.SyncPassword).HasMaxLength(500);
                entity.Property(e => e.SyncPasswordHashed).HasMaxLength(1000);
                entity.Property(e => e.SyncTasksLastDateTime).HasColumnType("datetime");
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.SyncUserName).HasMaxLength(50);
                entity.Property(e => e.TimeZone).HasMaxLength(50);
                entity.Property(e => e.TimeZoneCityNames).HasMaxLength(200);
                entity.Property(e => e.TimeZoneExchange).HasMaxLength(100);
                entity.Property(e => e.TimeZoneOffset).HasMaxLength(50);
                entity.Property(e => e.Title).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserActivationDate).HasColumnType("datetime");
                entity.Property(e => e.UserDeactivationDate).HasColumnType("datetime");
                entity.Property(e => e.UserGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false);
                entity.Property(e => e.UserRoles).HasMaxLength(500);
                entity.Property(e => e.Version).HasMaxLength(10);
            });

            modelBuilder.Entity<GlobalUserActivationsDeactivation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_UserActivationHistory");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ActivatedByUserName).HasMaxLength(50);
                entity.Property(e => e.ActivatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeactivatedByUserName).HasMaxLength(50);
                entity.Property(e => e.DeactivatedDate).HasColumnType("datetime");
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalUserActivity>(entity =>
            {
                entity.HasKey(e => e.GlobalUserActivityId).HasName("PK_UserActivity");

                entity.ToTable("GlobalUserActivity");

                entity.HasIndex(e => new { e.ContactId, e.ContactSubscriberId }, "IX_GlobalUserActivity");

                entity.HasIndex(e => e.GlobalCompanyId, "IX_GlobalUserActivity_GlobalCompanyId");

                entity.HasIndex(e => e.GlobalDealId, "IX_GlobalUserActivity_GlobalDealId");

                entity.HasIndex(e => new { e.SubscriberId, e.UserActivityId }, "nci_wi_GlobalUserActivity_E3803A753DEEC594BA26CCC96E2788F0");

                entity.Property(e => e.ActivityType).HasMaxLength(200);
                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.ContactName).HasMaxLength(200);
                entity.Property(e => e.DealName).HasMaxLength(200);
                entity.Property(e => e.FilterName).HasMaxLength(50);
                entity.Property(e => e.NoteContent).HasMaxLength(4000);
                entity.Property(e => e.QuoteName).HasMaxLength(50);
                entity.Property(e => e.Subject).HasMaxLength(200);
                entity.Property(e => e.SubscriberName).HasMaxLength(200);
                entity.Property(e => e.TaskName).HasMaxLength(200);
                entity.Property(e => e.UserActivityMessage).HasMaxLength(4000);
                entity.Property(e => e.UserActivityTimestamp).HasColumnType("datetime");
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<GoogleSyncErrorLog>(entity =>
            {
                entity.ToTable("GoogleSyncErrorLog");

                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");
                entity.Property(e => e.ErrorMessage).HasColumnType("ntext");
                entity.Property(e => e.ReturnMessage).HasColumnType("ntext");
                entity.Property(e => e.RoutineName).HasMaxLength(100);
                entity.Property(e => e.RoutineType).HasMaxLength(100);
            });

            modelBuilder.Entity<GoogleSyncLog>(entity =>
            {
                entity.HasKey(e => e.GoogleSyncLogId).HasName("PK_tblGoogleSyncLog");

                entity.ToTable("GoogleSyncLog");

                entity.Property(e => e.ElapsedTime).HasMaxLength(50);
                entity.Property(e => e.SyncEndTime).HasColumnType("datetime");
                entity.Property(e => e.SyncStartTime).HasColumnType("datetime");
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Incoterm>(entity =>
            {
                entity.Property(e => e.CarriageToPlaceOfDestination).HasMaxLength(10);
                entity.Property(e => e.CarriageToPortOfExport).HasMaxLength(10);
                entity.Property(e => e.CarriageToPortOfImport).HasMaxLength(10);
                entity.Property(e => e.CarrierLoadOnTruck).HasMaxLength(10);
                entity.Property(e => e.ExportCustomsDeclaration).HasMaxLength(10);
                entity.Property(e => e.ImportCustomsClearance).HasMaxLength(10);
                entity.Property(e => e.ImportTaxes).HasMaxLength(10);
                entity.Property(e => e.Incoterm1)
                    .HasMaxLength(3)
                    .HasColumnName("Incoterm");
                entity.Property(e => e.Insurance).HasMaxLength(10);
                entity.Property(e => e.LoadingChargesInPortOfExport).HasMaxLength(10);
                entity.Property(e => e.LoadingOnTruckInPortOfIimport).HasMaxLength(10);
                entity.Property(e => e.UnloadTruckInPortOfExport).HasMaxLength(10);
                entity.Property(e => e.UnloadingChargesInPortOfImport).HasMaxLength(10);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.AddressBlock).HasMaxLength(200);
                entity.Property(e => e.ContactEmail).HasMaxLength(50);
                entity.Property(e => e.ContactFirstName).HasMaxLength(50);
                entity.Property(e => e.ContactFullName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(10);
                entity.Property(e => e.CurrencySymbol).HasMaxLength(10);
                entity.Property(e => e.DateDeleted).HasColumnType("datetime");
                entity.Property(e => e.EndDate).HasColumnType("datetime");
                entity.Property(e => e.ExcelUrl).HasMaxLength(1000);
                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
                entity.Property(e => e.InvoiceGuid).HasMaxLength(50);
                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
                entity.Property(e => e.InvoiceText).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.PaidDate).HasColumnType("datetime");
                entity.Property(e => e.PdfUrl).HasMaxLength(1000);
                entity.Property(e => e.Phone).HasMaxLength(30);
                entity.Property(e => e.StartDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceActiveUser>(entity =>
            {
                entity.Property(e => e.BillingCode).HasMaxLength(20);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DateDeleted).HasColumnType("datetime");
                entity.Property(e => e.FullName).HasMaxLength(50);
                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationName).HasMaxLength(50);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.SubscriberCompanyName).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserActivationDate).HasColumnType("datetime");
                entity.Property(e => e.UserDeactivationDate).HasColumnType("datetime");
                entity.Property(e => e.UserEmail).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
                entity.Property(e => e.UserRole).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceContact>(entity =>
            {
                entity.HasKey(e => e.InvoiceContactId).HasName("PK_InvoiceContact");
            });

            modelBuilder.Entity<InvoiceEmail>(entity =>
            {
                entity.ToTable("InvoiceEmail");

                entity.Property(e => e.SentDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<InvoiceSent>(entity =>
            {
                entity.ToTable("InvoiceSent");

                entity.Property(e => e.EmailAddress).HasMaxLength(300);
                entity.Property(e => e.FullName).HasMaxLength(300);
                entity.Property(e => e.SentDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.ToCcBcc).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.ToTable("InvoiceStatus");

                entity.Property(e => e.InvoiceStatusId).ValueGeneratedNever();
                entity.Property(e => e.InvoiceStatus1)
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceStatus");
            });

            modelBuilder.Entity<InvoiceStatusHistory>(entity =>
            {
                entity.ToTable("InvoiceStatusHistory");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.StatusId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LanguageId).HasName("PK_tblLanguages");

                entity.Property(e => e.LanguageCode).HasMaxLength(6);
                entity.Property(e => e.LanguageName).HasMaxLength(50);
            });

            modelBuilder.Entity<LanguagePhrase>(entity =>
            {
                entity.HasKey(e => e.LanguagePhraseId).HasName("PK_tblLanguagePhrases");

                entity.HasIndex(e => e.LanguagePhrase1, "IX_LanguagePhrases_LanguagePhrase");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedByUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.LanguagePhrase1)
                    .HasMaxLength(200)
                    .HasColumnName("LanguagePhrase");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageTranslation>(entity =>
            {
                entity.HasKey(e => e.LanguageTranslationId).HasName("PK_tblLanguageTranslations");

                entity.HasIndex(e => e.LanguageCode, "IX_LanguageTranslations_LanguageCode");

                entity.HasIndex(e => e.LanguageName, "IX_LanguageTranslations_LanguageName");

                entity.HasIndex(e => e.LanguagePhrase, "IX_LanguageTranslations_LanguagePhrase");

                entity.HasIndex(e => e.Translation, "IX_LanguageTranslations_Translation");

                entity.HasIndex(e => new { e.LanguageCode, e.Verified }, "nci_wi_LanguageTranslations_098F508CEAB243DBB7076C569079F80D");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LanguageCode).HasMaxLength(6);
                entity.Property(e => e.LanguageName).HasMaxLength(50);
                entity.Property(e => e.LanguagePhrase).HasMaxLength(200);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.Translation).HasMaxLength(250);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.VerifiedUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkActivityToDeal>(entity =>
            {
                entity.ToTable("LinkActivityToDeal");

                entity.HasIndex(e => e.ActivityId, "IX_LinkActivityToDeal_ActivityId");

                entity.HasIndex(e => new { e.DealId, e.Deleted }, "nci_wi_LinkActivityToDeal_95ADA3F32612F23AC634480012EF864A");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserId).HasDefaultValueSql("((0))");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkCompanyToCompany>(entity =>
            {
                entity.HasKey(e => e.LinkCompanyToCompanyId).HasName("PK_LinkCompanyCompany");

                entity.ToTable("LinkCompanyToCompany");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_LinkCompanyToCompanyCompanyIdGlobal");

                entity.HasIndex(e => e.LinkedCompanyIdGlobal, "IX_LinkCompanyToCompany_LinkedCompanyIdGlobal");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkCompanyToCompany_SubscriberId");

                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkTypeName).HasMaxLength(100);
                entity.Property(e => e.LinkedCompanyName).HasMaxLength(100);
                entity.Property(e => e.OwnerApprovalGuid).HasMaxLength(100);
                entity.Property(e => e.OwnerApprovalStatus).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkCountryRegion>(entity =>
            {
                entity.ToTable("LinkCountryRegion");

                entity.HasIndex(e => e.CountryCode, "IX_LinkCountryRegion_CountryCode");

                entity.HasIndex(e => e.CountryName, "IX_LinkCountryRegion_CountryName");

                entity.HasIndex(e => e.RegionName, "IX_LinkCountryRegion_RegionName");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkCountryRegion_SubscriberId");

                entity.Property(e => e.CountryCode).HasMaxLength(10);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.RegionCode).HasMaxLength(10);
                entity.Property(e => e.RegionName).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkGlobalCompanyGlobalUser>(entity =>
            {
                entity.ToTable("LinkGlobalCompanyGlobalUser");

                entity.HasIndex(e => e.Deleted, "nci_wi_LinkGlobalCompanyGlobalUser_3385453A2252F86AC242B7E00D5F7325");

                entity.HasIndex(e => new { e.GlobalCompanyId, e.GlobalUserId, e.Deleted }, "nci_wi_LinkGlobalCompanyGlobalUser_4E279FADEDC4F2E729C9FEC27DF370BB");

                entity.HasIndex(e => e.Deleted, "nci_wi_LinkGlobalCompanyGlobalUser_C51D1C0979FF3B8D209398E00848236E");

                entity.HasIndex(e => new { e.GlobalUserId, e.GlobalCompanyId, e.Deleted }, "nci_wi_LinkGlobalCompanyGlobalUser_CB1A5B3EE57547D4C99AD3C4397A56A9");

                entity.Property(e => e.CreatedByName).HasMaxLength(1000);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.GlobalCompanyName).HasMaxLength(1000);
                entity.Property(e => e.GlobalUserName).HasMaxLength(1000);
                entity.Property(e => e.InviteGuid).HasMaxLength(50);
                entity.Property(e => e.InviteStatus).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(200);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(1000);
            });

            modelBuilder.Entity<LinkGlobalContactToCompany>(entity =>
            {
                entity.ToTable("LinkGlobalContactToCompany");

                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.ContactName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(100);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkGlobalContactToDeal>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_GlobalDealLinkContact");

                entity.ToTable("LinkGlobalContactToDeal");

                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkGlobalDealGlobalUser>(entity =>
            {
                entity.HasKey(e => e.LinkGloablDealGlobalUserId);

                entity.ToTable("LinkGlobalDealGlobalUser");

                entity.HasIndex(e => new { e.GlobalDealId, e.GlobalUserId, e.Deleted }, "nci_wi_LinkGlobalDealGlobalUser_41FA358F80584D7D7BE5149D7D47109F");

                entity.Property(e => e.CreatedByName).HasMaxLength(1000);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.GlobalDealName).HasMaxLength(1000);
                entity.Property(e => e.GlobalUserName).HasMaxLength(1000);
                entity.Property(e => e.InviteGuid).HasMaxLength(50);
                entity.Property(e => e.InviteStatus).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(200);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(200);
            });

            modelBuilder.Entity<LinkGlobalSuscriberToSubscriber>(entity =>
            {
                entity.HasKey(e => e.LinkGlobalSubscriberToSubscriberId).HasName("PK_Table_1");

                entity.ToTable("LinkGlobalSuscriberToSubscriber");

                entity.Property(e => e.DataCenter).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkGlobalUserToGlobalContact>(entity =>
            {
                entity.HasKey(e => e.LinkUserToGlobalContactId);

                entity.ToTable("LinkGlobalUserToGlobalContact");

                entity.Property(e => e.ContactName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(200);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.InviteGuid).HasMaxLength(50);
                entity.Property(e => e.InviteStatus).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(200);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<LinkGlobalUserToGlobalManager>(entity =>
            {
                entity.HasKey(e => e.LinkGlobalUserToGlobalManagerId).HasName("PK_tblLinkManagersSalesReps");

                entity.ToTable("LinkGlobalUserToGlobalManager");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DateDeleted).HasColumnType("datetime");
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.ManagerName).HasMaxLength(50);
                entity.Property(e => e.ManagerType).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
                entity.Property(e => e.UserRole).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkGlobalUserToManagingCountry>(entity =>
            {
                entity.ToTable("LinkGlobalUserToManagingCountry");

                entity.Property(e => e.CountryName).HasMaxLength(150);
            });

            modelBuilder.Entity<LinkSubscriberToStripeCustomer>(entity =>
            {
                entity.ToTable("LinkSubscriberToStripeCustomer");

                entity.HasKey(e => e.SubscriberId);
                entity.Property(e => e.SubscriberId)
                    .ValueGeneratedNever();
                entity.HasIndex(e => e.SubscriberId, "IX_LinkSubscriberToStripeCustomer_GlobalUserId")
                    .IsUnique();
                entity.Property(e => e.StripeCustomerId).HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.MessageCcglobalUsers).HasColumnName("MessageCCGlobalUsers");
                entity.Property(e => e.MessageContentType)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.MessageGuid).HasMaxLength(50);
                entity.Property(e => e.MessageSentDeletedDate).HasColumnType("datetime");
                entity.Property(e => e.MessageSentDeletedUserName).HasMaxLength(50);
                entity.Property(e => e.MessageToUserName).HasMaxLength(50);
                entity.Property(e => e.MessageType).HasMaxLength(20);
                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<OutlookCategoryColor>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName).HasMaxLength(50);
                entity.Property(e => e.Color).HasMaxLength(50);
                entity.Property(e => e.HexColor).HasMaxLength(50);
                entity.Property(e => e.Rgb)
                    .HasMaxLength(50)
                    .HasColumnName("RGB");
            });

            modelBuilder.Entity<ReassignUserRequest>(entity =>
            {
                entity.ToTable("ReassignUserRequest");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");
                entity.Property(e => e.CurrentProcessingType).HasMaxLength(200);
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.RequestedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionId).HasName("PK_tblRegions");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.FilterName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.ReportType).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesTeamRole>(entity =>
            {
                entity.HasKey(e => e.SalesTeamRoleId).HasName("PK_SalesTeamRoleId");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.SalesTeamRole1)
                    .HasMaxLength(50)
                    .HasColumnName("SalesTeamRole");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.Property(e => e.SubscriberId).ValueGeneratedNever();
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.AirVolumeDisplay).HasMaxLength(50);
                entity.Property(e => e.Billable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.BillingCurrencyCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'US')");
                entity.Property(e => e.BillingCurrencySymbol)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'$')");
                entity.Property(e => e.BillingFrequency).HasMaxLength(50);
                entity.Property(e => e.BillingUserRate).HasColumnType("money");
                entity.Property(e => e.BillingUserReadOnlyRate).HasColumnType("money");
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.CompanyCodeText).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(500);
                entity.Property(e => e.CompanyParentCodeText).HasMaxLength(50);
                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.ConversionDataCenter).HasMaxLength(50);
                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'United States')");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CrmAdminEmail).HasMaxLength(50);
                entity.Property(e => e.DataCenter).HasMaxLength(50);
                entity.Property(e => e.DefaultDateFormat)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'dd/mm/yyyy')");
                entity.Property(e => e.DefaultLeadResponseDays).HasDefaultValueSql("((2))");
                entity.Property(e => e.DefaultReportCurrencyCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'US')");
                entity.Property(e => e.DefaultReportDateFormat)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'dd/mmm/yyyy')");
                entity.Property(e => e.DefaultShippingFrequency)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Per Year')");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DisplayTotalsValueFrequency).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.EmailDisclaimer).HasMaxLength(4000);
                entity.Property(e => e.EmailFrom).HasMaxLength(50);
                entity.Property(e => e.ExchangeDomain).HasMaxLength(50);
                entity.Property(e => e.ExchangeServerTimeZone).HasMaxLength(100);
                entity.Property(e => e.ExchangeUrl).HasMaxLength(100);
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LogonUrl).HasMaxLength(50);
                entity.Property(e => e.Phone).HasMaxLength(50);
                entity.Property(e => e.PostalCode).HasMaxLength(10);
                entity.Property(e => e.SsoApiKey).HasMaxLength(500);
                entity.Property(e => e.StateProvince).HasMaxLength(50);
                entity.Property(e => e.SubDomain).HasMaxLength(50);
                entity.Property(e => e.SubscriberApiKey).HasMaxLength(500);
                entity.Property(e => e.SubscriberGuid).HasMaxLength(50);
                entity.Property(e => e.SubscriberIpAddress).HasMaxLength(50);
                entity.Property(e => e.SubscriberType).HasMaxLength(50);
                entity.Property(e => e.SyncServiceDomain).HasMaxLength(100);
                entity.Property(e => e.SyncServicePassword).HasMaxLength(500);
                entity.Property(e => e.SyncServiceUrl).HasMaxLength(100);
                entity.Property(e => e.SyncServiceUserName).HasMaxLength(50);
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SubscriberTransfer>(entity =>
            {
                entity.ToTable("SubscriberTransfer");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");
                entity.Property(e => e.DestinationDataCenter).HasMaxLength(50);
                entity.Property(e => e.Guid).HasMaxLength(50);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.StartDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SubscriberTransferStep>(entity =>
            {
                entity.ToTable("SubscriberTransferStep");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");
                entity.Property(e => e.StartedDate).HasColumnType("datetime");
                entity.Property(e => e.StepStr).HasMaxLength(500);

                entity.HasOne(d => d.SubscriberTransfer).WithMany(p => p.SubscriberTransferSteps)
                    .HasForeignKey(d => d.SubscriberTransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriberTransferStep_SubscriberTransferStep");
            });

            modelBuilder.Entity<SubscriberTransferStepError>(entity =>
            {
                entity.ToTable("SubscriberTransferStepError");

                entity.Property(e => e.SubscriberTransferStepErrorId).ValueGeneratedNever();
                entity.Property(e => e.RefType).HasMaxLength(200);

                entity.HasOne(d => d.SubscriberTransferStep).WithMany(p => p.SubscriberTransferStepErrors)
                    .HasForeignKey(d => d.SubscriberTransferStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriberTransferStepError_SubscriberTransferStep");
            });

            modelBuilder.Entity<SwitchUserRequest>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_SwitchUserSession");

                entity.ToTable("SwitchUserRequest");

                entity.Property(e => e.Guid).HasMaxLength(50);
                entity.Property(e => e.Source).HasMaxLength(50);
                entity.Property(e => e.SwitchDateTime)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.SwitchToGlobalUserDataCenter).HasMaxLength(50);
            });

            modelBuilder.Entity<TableStatus>(entity =>
            {
                entity.ToTable("TableStatus");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdateUserName).HasMaxLength(50);
                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<Text>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.ErrorDetails).HasMaxLength(200);
                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
                entity.Property(e => e.TextFrom).HasMaxLength(50);
                entity.Property(e => e.TextFromUserName).HasMaxLength(50);
                entity.Property(e => e.TextTo).HasMaxLength(50);
                entity.Property(e => e.TextToName).HasMaxLength(50);
                entity.Property(e => e.TextType).HasMaxLength(50);
                entity.Property(e => e.TwillioSid).HasMaxLength(50);
            });

            modelBuilder.Entity<FirstFreightAPI.Entities.Shared.TimeZone>(entity =>
            {
                entity.Property(e => e.CityNames).HasMaxLength(255);
                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.EnumTimeZoneId)
                    .HasMaxLength(50)
                    .HasColumnName("EnumTimeZoneID");
                entity.Property(e => e.Region).HasMaxLength(50);
                entity.Property(e => e.TimeZoneIana)
                    .HasMaxLength(50)
                    .HasColumnName("TimeZoneIANA");
                entity.Property(e => e.TimeZoneName).HasMaxLength(50);
                entity.Property(e => e.UtcOffset).HasMaxLength(20);
            });

            modelBuilder.Entity<TimeZonesDaylightSaving>(entity =>
            {
                entity.HasKey(e => e.TimeZonesDaylightSavingsId).HasName("PK_TimeZones_DST1");

                entity.Property(e => e.DstEndDate).HasColumnType("datetime");
                entity.Property(e => e.DstStartDate).HasColumnType("datetime");
                entity.Property(e => e.TimeZoneFullName).HasMaxLength(100);
                entity.Property(e => e.TimeZoneName).HasMaxLength(50);
                entity.Property(e => e.UtcOffset).HasMaxLength(20);
            });

            modelBuilder.Entity<UnlocoCode>(entity =>
            {
                entity.HasKey(e => e.UnlocoCodeId).HasName("PK_UNLocoCodes");

                entity.HasIndex(e => e.CountryName, "IX_UnlocoCodes_CountryName");

                entity.HasIndex(e => e.LocationName, "IX_UnlocoCodes_LocationName");

                entity.HasIndex(e => e.PortName, "IX_UnlocoCodes_PortName");

                entity.HasIndex(e => e.UnlocoCode1, "IX_UnlocoCodes_UnlocoCode");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Coordinates).HasMaxLength(100);
                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.IataCode).HasMaxLength(20);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationDate).HasMaxLength(12);
                entity.Property(e => e.LocationFunction).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(100);
                entity.Property(e => e.LocationNameWithDiacriticals).HasMaxLength(100);
                entity.Property(e => e.PortName).HasMaxLength(50);
                entity.Property(e => e.SubdivisionCode).HasMaxLength(5);
                entity.Property(e => e.UnlocoCode1)
                    .HasMaxLength(20)
                    .HasColumnName("UnlocoCode");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserEmailLink>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.Link).HasMaxLength(2000);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.SubscriberId, "IX_UserRoles_SubscriberId");

                entity.HasIndex(e => e.UserRole1, "IX_UserRoles_UserRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(200);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserRole1)
                    .HasMaxLength(50)
                    .HasColumnName("UserRole");
            });

            modelBuilder.Entity<WebAppError>(entity =>
            {
                entity.Property(e => e.ErrorCallStack).HasMaxLength(4000);
                entity.Property(e => e.ErrorCode).HasMaxLength(10);
                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");
                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
                entity.Property(e => e.PageCalledFrom).HasMaxLength(50);
                entity.Property(e => e.RoutineName).HasMaxLength(100);
                entity.Property(e => e.SubscriberName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowAccount>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.NylasAccessToken).HasMaxLength(50);
                entity.Property(e => e.NylasAccountId).HasMaxLength(50);
                entity.Property(e => e.NylasCalendarId).HasMaxLength(50);
                entity.Property(e => e.NylasConnectedDate).HasColumnType("datetime");
                entity.Property(e => e.NylasEmail).HasMaxLength(150);
                entity.Property(e => e.NylasProvider).HasMaxLength(50);
                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'added')");
            });

            modelBuilder.Entity<WorkflowAccountEvent>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.JobStatus).HasMaxLength(20);
                entity.Property(e => e.JobStatusId).HasMaxLength(50);
                entity.Property(e => e.JobStatusStartDate).HasColumnType("datetime");
                entity.Property(e => e.JobStatusType).HasMaxLength(20);
                entity.Property(e => e.LastWebhookDate).HasColumnType("datetime");
                entity.Property(e => e.LastWebhookStatus).HasMaxLength(20);
                entity.Property(e => e.NylasEventId).HasMaxLength(50);
            });
        }
    }
}
