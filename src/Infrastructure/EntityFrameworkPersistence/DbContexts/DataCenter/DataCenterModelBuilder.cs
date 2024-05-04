using FirstFreightAPI.Entities.DataCenter;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.DbContexts.DataCenter
{
    internal class DataCenterModelBuilder
    {
        internal static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.HasIndex(e => e.CompanyIdGlobal, "IX_CalendarEvents_CompanyIdGlobal");

                entity.HasIndex(e => e.ExchangeSyncLastModified, "IX_CalendarEvents_ExchangeSyncLastModified");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.DealId, "IX_DealId");

                entity.HasIndex(e => e.EndDateTime, "IX_EndDateTime");

                entity.HasIndex(e => e.ExchangeAppointmentId, "IX_ExchangeAppointmentId");

                entity.HasIndex(e => e.GoogleSyncId, "IX_GoogleSyncId");

                entity.HasIndex(e => e.OwnerUserId, "IX_OwnerUserId");

                entity.HasIndex(e => e.ReminderDate, "IX_ReminderDate");

                entity.HasIndex(e => e.StartDateTime, "IX_StartDateTime");

                entity.HasIndex(e => e.SubscriberId, "IX_SubscriberId");

                entity.HasIndex(e => e.Tags, "IX_Tags");

                entity.HasIndex(e => new { e.OwnerUserId, e.Deleted }, "nci_wi_CalendarEvents_6B6A373C4E0061AAE7DFCD28523C109D");

                entity.HasIndex(e => new { e.OwnerUserId, e.SubscriberId, e.Deleted }, "nci_wi_CalendarEvents_7B7177B03FA0BEB2C1F509111F85B516");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted }, "nci_wi_CalendarEvents_8FEE9C2ACBCED0C144E29EA252905070");

                entity.HasIndex(e => new { e.SubscriberId, e.CreatedUserId, e.CreatedDate }, "nci_wi_CalendarEvents_F2693BDAEE4C966F3F04C55CC005A0EE");

                entity.Property(e => e.AdminActiveOveride).HasDefaultValueSql("((0))");
                entity.Property(e => e.AdminActiveOverideDate).HasColumnType("datetime");
                entity.Property(e => e.BusyFree).HasMaxLength(5);
                entity.Property(e => e.Campaigns).HasMaxLength(1000);
                entity.Property(e => e.CategoryColor).HasMaxLength(50);
                entity.Property(e => e.CategoryName).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.Competitors).HasMaxLength(1000);
                entity.Property(e => e.ContactIds).HasMaxLength(1000);
                entity.Property(e => e.Contacts).HasMaxLength(1000);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(100);
                entity.Property(e => e.DealName).HasMaxLength(200);
                entity.Property(e => e.DealTypes).HasMaxLength(1000);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(100);
                entity.Property(e => e.Duration).HasDefaultValueSql("((30))");
                entity.Property(e => e.EndDateTime).HasColumnType("datetime");
                entity.Property(e => e.EventTimeZone).HasMaxLength(100);
                entity.Property(e => e.EventType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Meeting')");
                entity.Property(e => e.ExchangeAppointmentId).HasMaxLength(400);
                entity.Property(e => e.ExchangeAppointmentItemId).HasMaxLength(1000);
                entity.Property(e => e.ExchangeSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.GoogleSyncId).HasMaxLength(400);
                entity.Property(e => e.GoogleSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.IsRecurring).HasDefaultValueSql("((0))");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.Location).HasMaxLength(500);
                entity.Property(e => e.OriginSystem).HasMaxLength(100);
                entity.Property(e => e.OwnerUserName).HasMaxLength(1000);
                entity.Property(e => e.Priority).HasMaxLength(100);
                entity.Property(e => e.PublicPrivate).HasMaxLength(10);
                entity.Property(e => e.ReminderDate).HasColumnType("datetime");
                entity.Property(e => e.ReminderIncrementType).HasMaxLength(25);
                entity.Property(e => e.ReminderType).HasMaxLength(10);
                entity.Property(e => e.ReoccurrenceIncrementType).HasMaxLength(25);
                entity.Property(e => e.SalesPurpose).HasMaxLength(50);
                entity.Property(e => e.SalesStage).HasMaxLength(100);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
                entity.Property(e => e.Subject).HasMaxLength(500);
                entity.Property(e => e.SyncType).HasMaxLength(20);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.UpdateUserName).HasMaxLength(100);
                entity.Property(e => e.UserLocation).HasMaxLength(200);
                entity.Property(e => e.UserTimeZone).HasMaxLength(100);
                entity.Property(e => e.UtcOffset).HasMaxLength(50);
            });

            modelBuilder.Entity<CalendarInvite>(entity =>
            {
                entity.HasKey(e => e.CalendarEventInviteId);

                entity.HasIndex(e => e.ContactId, "IX_CalendarInvites_ContactId");

                entity.HasIndex(e => e.Email, "IX_CalendarInvites_Email");

                entity.HasIndex(e => e.SubscriberId, "IX_CalendarInvites_SubscriberId");

                entity.HasIndex(e => e.UserId, "IX_CalendarInvites_UserId");

                entity.HasIndex(e => new { e.UserId, e.Deleted }, "nci_wi_CalendarInvites_1505822F3803EBEB09ABD18BE8D19485");

                entity.HasIndex(e => new { e.CalendarEventId, e.Deleted }, "nci_wi_CalendarInvites_5F590023E04CF22605D3CCE11755DF6E");

                entity.Property(e => e.AttendeeType).HasMaxLength(50);
                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.InviteType).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.HasIndex(e => e.SubscriberId, "IX_Commodities");

                entity.HasIndex(e => e.CommodityName, "IX_Commodities_CommidityName");

                entity.Property(e => e.CommodityName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Companies_CompanyIdGlobal");

                entity.HasIndex(e => e.CompanyOwnerUserId, "IX_Companies_CompanyOwnerUserId");

                entity.HasIndex(e => e.ControllingSalesRepCode, "IX_Companies_ControllingSalesRepCode");

                entity.HasIndex(e => e.CountryName, "IX_Companies_CountryName");

                entity.HasIndex(e => e.Industry, "IX_Companies_Industry");

                entity.HasIndex(e => e.MaintenanceSalesRepCode, "IX_Companies_MaintenanceSalesRepCode");

                entity.HasIndex(e => e.SalesTeam, "IX_Companies_SalesTeam");

                entity.HasIndex(e => e.SubscriberId, "IX_Companies_SubscriberId");

                entity.HasIndex(e => e.ConversionLeadId, "nci_wi_Companies_118C1338F3B2A1AED94FA5629E286632");

                entity.HasIndex(e => new { e.CreatedUserId, e.SubscriberId, e.CreatedDate }, "nci_wi_Companies_4535527C3A0218F6C8E86BA78CBCF3A3");

                entity.HasIndex(e => e.ConversionAccountId, "nci_wi_Companies_511A36AD4FFEDBE68830EA91CA8CC2FA");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted }, "nci_wi_Companies_B2A9E8D0BC167FC366E11FB3852F1596");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Address).HasMaxLength(2000);
                entity.Property(e => e.AdminOverideActive).HasDefaultValueSql("((0))");
                entity.Property(e => e.AdminOverideActiveDate).HasColumnType("datetime");
                entity.Property(e => e.AnnualShipments).HasMaxLength(200);
                entity.Property(e => e.AnnualVolumes).HasMaxLength(200);
                entity.Property(e => e.CampaignName).HasMaxLength(500);
                entity.Property(e => e.City).HasMaxLength(200);
                entity.Property(e => e.Claimed).HasDefaultValueSql("((0))");
                entity.Property(e => e.ClaimedDate).HasColumnType("datetime");
                entity.Property(e => e.ClaimedUserName).HasMaxLength(50);
                entity.Property(e => e.Commodities).HasMaxLength(500);
                entity.Property(e => e.CompanyCode).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(1000);
                entity.Property(e => e.CompanySegmentCode).HasMaxLength(20);
                entity.Property(e => e.CompanySegmentName).HasMaxLength(50);
                entity.Property(e => e.CompanyTypes).HasMaxLength(500);
                entity.Property(e => e.Competitors).HasMaxLength(500);
                entity.Property(e => e.ControllingSalesRepCode).HasMaxLength(10);
                entity.Property(e => e.ConversionType).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(50);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CreditLimit)
                    .HasDefaultValueSql("((0))")
                    .HasColumnType("money");
                entity.Property(e => e.CustomerBillingCode).HasMaxLength(20);
                entity.Property(e => e.DaysNoShipments).HasDefaultValueSql("((0))");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Destinations).HasMaxLength(200);
                entity.Property(e => e.Division).HasMaxLength(200);
                entity.Property(e => e.DunsNumber).HasMaxLength(30);
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");
                entity.Property(e => e.FirstShipmentDate).HasColumnType("datetime");
                entity.Property(e => e.FreightServices).HasMaxLength(200);
                entity.Property(e => e.Incoterms).HasMaxLength(500);
                entity.Property(e => e.Industry).HasMaxLength(50);
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastCreditUpdate).HasColumnType("datetime");
                entity.Property(e => e.LastShipmentDate).HasColumnType("smalldatetime");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.MaintenanceSalesRepCode).HasMaxLength(10);
                entity.Property(e => e.NextActivityDate).HasColumnType("datetime");
                entity.Property(e => e.OriginSystem).HasMaxLength(50);
                entity.Property(e => e.OriginSystemSalesRepCodes).HasMaxLength(10);
                entity.Property(e => e.OriginatingUserName).HasMaxLength(100);
                entity.Property(e => e.Origins).HasMaxLength(200);
                entity.Property(e => e.ParentCode).HasMaxLength(50);
                entity.Property(e => e.ParentCompanyName)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.Phone).HasMaxLength(50);
                entity.Property(e => e.Phone2).HasMaxLength(50);
                entity.Property(e => e.PostalCode).HasMaxLength(200);
                entity.Property(e => e.PrimaryContactId).HasDefaultValueSql("((0))");
                entity.Property(e => e.SalesTeam).HasMaxLength(200);
                entity.Property(e => e.ServiceSalesRepCode).HasMaxLength(6);
                entity.Property(e => e.Siccode)
                    .HasMaxLength(50)
                    .HasColumnName("SICCode");
                entity.Property(e => e.Source).HasMaxLength(50);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.StateProvince).HasMaxLength(500);
                entity.Property(e => e.Status).HasMaxLength(20);
                entity.Property(e => e.Tags).HasMaxLength(500);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyLinkType>(entity =>
            {
                entity.HasKey(e => e.CompanyLinkTypeId).HasName("PK_CompanyLinkTypes_CompanyLinkTypeName");

                entity.HasIndex(e => e.SubscriberId, "IX_CompanyLinkTypes_SubscriberId");

                entity.Property(e => e.CompanyLinkTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanySegment>(entity =>
            {
                entity.HasIndex(e => e.SegmentCode, "IX_CompanySegments_SegmentCode");

                entity.HasIndex(e => e.SegmentName, "IX_CompanySegments_SegmentName");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.SegmentCode).HasMaxLength(20);
                entity.Property(e => e.SegmentName).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.HasKey(e => e.CompanyTypeId).HasName("PK_CompanyType");

                entity.HasIndex(e => e.CompanyTypeName, "IX_CompanyTypeName");

                entity.HasIndex(e => e.SubscriberId, "IX_CompanyType_SubscriberId");

                entity.Property(e => e.CompanyTypeName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Competitor>(entity =>
            {
                entity.HasIndex(e => e.CompetitorName, "IX_Competitors_CompetitorName");

                entity.HasIndex(e => e.SortOrder, "IX_Competitors_SortOrder");

                entity.HasIndex(e => e.SubscriberId, "IX_Competitors_SubscriberId");

                entity.Property(e => e.CompetitorName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId).HasName("PK_tblContacts");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Contacts_CompanyIdGlobal");

                entity.HasIndex(e => e.ContactName, "IX_Contacts_ContactName");

                entity.HasIndex(e => e.ContactOwnerUserId, "IX_Contacts_ContactOwnerUserId");

                entity.HasIndex(e => e.Email, "IX_Contacts_Email");

                entity.HasIndex(e => e.ExchangeContactId, "IX_Contacts_ExchangeContactId");

                entity.HasIndex(e => e.ExchangeSyncLastModified, "IX_Contacts_ExchangeSyncLastModified");

                entity.HasIndex(e => e.SalesTeam, "IX_Contacts_SalesTeam");

                entity.HasIndex(e => e.SubscriberId, "IX_Contacts_SubscriberId");

                entity.HasIndex(e => new { e.CompanyId, e.Deleted }, "nci_wi_Contacts_0EDFBC945A5C60D96934165DD139B3A8");

                entity.HasIndex(e => e.ConversionContactId, "nci_wi_Contacts_1497B5FD84143A0D65700331DAE69682");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted }, "nci_wi_Contacts_B2A9E8D0BC167FC366E11FB3852F1596");

                entity.Property(e => e.BusinessAddress).HasMaxLength(500);
                entity.Property(e => e.BusinessCity).HasMaxLength(100);
                entity.Property(e => e.BusinessCountry).HasMaxLength(100);
                entity.Property(e => e.BusinessCountryCode).HasMaxLength(3);
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
                entity.Property(e => e.ConversionContactDataCenter).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CustomerType).HasMaxLength(50);
                entity.Property(e => e.DecisionRole).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(300);
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
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasKey(e => e.ContactTypeId).HasName("PK_tblContactTypes");

                entity.HasIndex(e => e.ContactTypeName, "IX_ContactTypeName");

                entity.HasIndex(e => e.SortOrder, "IX_ContactTypes_SortOrder");

                entity.Property(e => e.ContactTypeName).HasMaxLength(30);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_Deals_CompanyId");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Deals_CompanyIdGlobal");

                entity.HasIndex(e => e.DealName, "IX_Deals_DealName");

                entity.HasIndex(e => e.DealOwnerId, "IX_Deals_DealOwnerId");

                entity.HasIndex(e => e.Industry, "IX_Deals_Industry");

                entity.HasIndex(e => e.LastActivityDate, "IX_Deals_LastActivityDate");

                entity.HasIndex(e => e.NextActivityDate, "IX_Deals_NextActivityDate");

                entity.HasIndex(e => e.SalesTeam, "IX_Deals_SalesTeam");

                entity.HasIndex(e => new { e.CompanyId, e.Deleted }, "nci_wi_Deals_0EDFBC945A5C60D96934165DD139B3A8");

                entity.HasIndex(e => new { e.SalesStageId, e.SubscriberId, e.Deleted }, "nci_wi_Deals_149AE824B55C1EA3B980A941A1E86158");

                entity.HasIndex(e => new { e.CreatedUserId, e.SubscriberId, e.DealName }, "nci_wi_Deals_5B9BA1CEFABDDA45D9EAA31B39225BEF");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted }, "nci_wi_Deals_6A9E78E6CC3B2CE5F42F4B6BBD65E449");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted }, "nci_wi_Deals_86C3AD1ABF5C011316CF3B792B14C4BA");

                entity.HasIndex(e => new { e.SubscriberId, e.Deleted, e.SpotDeal, e.SalesStageName }, "nci_wi_Deals_9481533237900D51D819B2FDC78E2BE3");

                entity.HasIndex(e => new { e.SubscriberId, e.CreatedUserId, e.CreatedDate }, "nci_wi_Deals_9AC6036058EC77D2E49CB613E517DA4F");

                entity.HasIndex(e => new { e.Deleted, e.RevenueUsdspot, e.SubscriberId, e.SalesStageName, e.CompanyId }, "nci_wi_Deals_EFCFD17E4BFF73484AB95595DCCEEFFB");

                entity.HasIndex(e => new { e.ConversionOpportunityId, e.SubscriberId }, "nci_wi_Deals_F828347FEB30668DA43B1A538B6B0424");

                entity.Property(e => e.Campaign).HasMaxLength(500);
                entity.Property(e => e.Cbms).HasColumnName("CBMs");
                entity.Property(e => e.CbmsSpot).HasColumnName("CBMsSpot");
                entity.Property(e => e.CommissionStartDate).HasColumnType("datetime");
                entity.Property(e => e.CommissionType).HasMaxLength(20);
                entity.Property(e => e.Commodities).HasMaxLength(1000);
                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.Competitors).HasMaxLength(500);
                entity.Property(e => e.ConsigneeNames).HasMaxLength(3000);
                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");
                entity.Property(e => e.ContractStartDate).HasColumnType("datetime");
                entity.Property(e => e.ConversionEntityName).HasMaxLength(100);
                entity.Property(e => e.ConversionSalesRepCode).HasMaxLength(8);
                entity.Property(e => e.ConversionSalesRepName).HasMaxLength(50);
                entity.Property(e => e.CountryCode).HasMaxLength(5);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(50);
                entity.Property(e => e.DateLost).HasColumnType("datetime");
                entity.Property(e => e.DateProposalDue).HasColumnType("datetime");
                entity.Property(e => e.DateWon).HasColumnType("datetime");
                entity.Property(e => e.DealCountryName).HasMaxLength(30);
                entity.Property(e => e.DealDescription).HasMaxLength(4000);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DealNumber).HasMaxLength(50);
                entity.Property(e => e.DealRequestType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.DealSource).HasMaxLength(200);
                entity.Property(e => e.DealType).HasMaxLength(50);
                entity.Property(e => e.DecisionDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DestinationCountries).HasMaxLength(3000);
                entity.Property(e => e.DestinationLocations).HasMaxLength(3000);
                entity.Property(e => e.DestinationRegions).HasMaxLength(3000);
                entity.Property(e => e.DistrictCode).HasMaxLength(10);
                entity.Property(e => e.DistrictName).HasMaxLength(50);
                entity.Property(e => e.EstimatedStartDate).HasColumnType("datetime");
                entity.Property(e => e.Feus).HasColumnName("FEUs");
                entity.Property(e => e.FeusSpot).HasColumnName("FEUsSpot");
                entity.Property(e => e.Incoterms).HasMaxLength(500);
                entity.Property(e => e.Industry).HasMaxLength(50);
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(50);
                entity.Property(e => e.NextActionDate).HasColumnType("datetime");
                entity.Property(e => e.NextActionStep).HasMaxLength(100);
                entity.Property(e => e.NextActivityDate).HasColumnType("datetime");
                entity.Property(e => e.OriginCountries).HasMaxLength(3000);
                entity.Property(e => e.OriginLocations).HasMaxLength(3000);
                entity.Property(e => e.OriginRegions).HasMaxLength(3000);
                entity.Property(e => e.OrignCountries).HasMaxLength(3000);
                entity.Property(e => e.OrignLocations).HasMaxLength(3000);
                entity.Property(e => e.OrignRegions).HasMaxLength(3000);
                entity.Property(e => e.PrimaryContactName).HasMaxLength(100);
                entity.Property(e => e.Products).HasMaxLength(200);
                entity.Property(e => e.ProfitUsd).HasColumnName("ProfitUSD");
                entity.Property(e => e.ProfitUsdspot).HasColumnName("ProfitUSDSpot");
                entity.Property(e => e.Ranking).HasMaxLength(50);
                entity.Property(e => e.ReasonWonLost).HasMaxLength(50);
                entity.Property(e => e.RegionCode).HasMaxLength(10);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.RevenueUsd).HasColumnName("RevenueUSD");
                entity.Property(e => e.RevenueUsdspot).HasColumnName("RevenueUSDSpot");
                entity.Property(e => e.SalesRepName).HasMaxLength(50);
                entity.Property(e => e.SalesStageName).HasMaxLength(50);
                entity.Property(e => e.SalesTeam).HasMaxLength(200);
                entity.Property(e => e.Services).HasMaxLength(1000);
                entity.Property(e => e.ShipperNames).HasMaxLength(3000);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.Tags).HasMaxLength(50);
                entity.Property(e => e.Teus).HasColumnName("TEUs");
                entity.Property(e => e.TeusSpot).HasColumnName("TEUsSpot");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<DealInvite>(entity =>
            {
                entity.Property(e => e.DateInviteSent).HasColumnType("datetime");
                entity.Property(e => e.DealInviteToken).HasDefaultValueSql("(newid())");
                entity.Property(e => e.DealName).HasMaxLength(50);
                entity.Property(e => e.InviteAcceptedDate).HasColumnType("datetime");
                entity.Property(e => e.InvitedBySalesRepCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.InvitedByUserName).HasMaxLength(50);
                entity.Property(e => e.InviteeEmail).HasMaxLength(50);
                entity.Property(e => e.InviteeName).HasMaxLength(100);
                entity.Property(e => e.InviteePhoneNumber).HasMaxLength(50);
                entity.Property(e => e.InviteeSalesRepCode).HasMaxLength(10);
                entity.Property(e => e.InviteeType).HasMaxLength(50);

                entity.HasOne(d => d.Subscriber).WithMany(p => p.DealInvites)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_DealInvites_SubscriberId");
            });

            modelBuilder.Entity<DealNotification>(entity =>
            {
                entity.Property(e => e.DealInviteToken).HasDefaultValueSql("(newid())");
                entity.Property(e => e.DealName).HasMaxLength(50);
                entity.Property(e => e.InvitedBySalesRepCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.InvitedByUserName).HasMaxLength(50);
                entity.Property(e => e.InviteeEmail).HasMaxLength(50);
                entity.Property(e => e.InviteeName).HasMaxLength(100);
                entity.Property(e => e.InviteePhoneNumber).HasMaxLength(50);
                entity.Property(e => e.InviteeSalesRepCode).HasMaxLength(10);
                entity.Property(e => e.NotificationDate).HasColumnType("datetime");
                entity.Property(e => e.NotificationMessage).HasMaxLength(4000);
                entity.Property(e => e.NotificationSubject).HasMaxLength(50);
            });

            modelBuilder.Entity<DealSalesStageHistory>(entity =>
            {
                entity.Property(e => e.AddedByName).HasMaxLength(500);
                entity.Property(e => e.AddedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.RemovedByName).HasMaxLength(500);
                entity.Property(e => e.RemovedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DealType>(entity =>
            {
                entity.HasKey(e => e.DealTypeId).HasName("PK_DealType");

                entity.HasIndex(e => e.DealTypeName, "IX_DealTypeName");

                entity.HasIndex(e => e.SortOrder, "IX_DealTypeSortOrder");

                entity.HasIndex(e => e.SubscriberId, "IX_DealTypeSubscriberId");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealTypeName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(500);
                entity.Property(e => e.CountryCode).HasMaxLength(2);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DistrictCode).HasMaxLength(5);
                entity.Property(e => e.DistrictManagerName).HasMaxLength(50);
                entity.Property(e => e.DistrictName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);

                entity.HasOne(d => d.Subscriber).WithMany(p => p.Districts)
                    .HasForeignKey(d => d.SubscriberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Districts_SubscriberId");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentId).HasName("PK_tblDocuments");

                entity.HasIndex(e => e.CalendarEventId, "IX_Documents_CalendarEventId");

                entity.HasIndex(e => e.CompanyId, "IX_Documents_CompanyId");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_Documents_CompanyIdGlobal");

                entity.HasIndex(e => e.ContactId, "IX_Documents_ContactId");

                entity.HasIndex(e => e.DealId, "IX_Documents_DealId");

                entity.HasIndex(e => e.EmailId, "IX_Documents_EmailId");

                entity.HasIndex(e => e.SubscriberId, "IX_Documents_SubscriberId");

                entity.HasIndex(e => e.Tags, "IX_Documents_Tags");

                entity.HasIndex(e => e.UserId, "IX_Documents_UserId");

                entity.HasIndex(e => new { e.DocumentType, e.UserId, e.Deleted }, "nci_wi_Documents_A73B1297A7D63B62D1978852FBDDFC37");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.DocumentBlobContainer).HasMaxLength(50);
                entity.Property(e => e.DocumentBlobReference).HasMaxLength(500);
                entity.Property(e => e.FileName).HasMaxLength(100);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.Title).HasMaxLength(300);
                entity.Property(e => e.UploadedByName).HasMaxLength(50);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_tblDocumentTypes");

                entity.Property(e => e.DocumentTypeText).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.EmailAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("EmailAddress");
            });

            modelBuilder.Entity<EmailAttachment>(entity =>
            {
                entity.HasKey(e => e.EmailAttachmentId).HasName("PK_tblEmailAttachments");

                entity.Property(e => e.ContentType).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.FileName).HasMaxLength(100);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.EmailSignature).HasMaxLength(500);
                entity.Property(e => e.EmailType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((-1))");
                entity.Property(e => e.FromEmail).HasMaxLength(50);
                entity.Property(e => e.FromName).HasMaxLength(100);
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.SendAtTime).HasColumnType("datetime");
                entity.Property(e => e.SendOnDay).HasMaxLength(15);
                entity.Property(e => e.Tags).HasMaxLength(100);
                entity.Property(e => e.TemplateSubject).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserRole).HasMaxLength(50);
                entity.Property(e => e.WeeklyEmailIncludes).HasMaxLength(500);
            });

            modelBuilder.Entity<EventCategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryName, "IX_EventCategories_CategoryName");

                entity.HasIndex(e => e.SubscriberId, "IX_EventCategories_SubscriberId");

                entity.Property(e => e.CategoryColor).HasMaxLength(20);
                entity.Property(e => e.CategoryColorNameOutlook).HasMaxLength(50);
                entity.Property(e => e.CategoryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<EventCompany>(entity =>
            {
                entity.HasKey(e => e.EventCompanyId).HasName("PK_EventCompanys");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_EventCompanies_CompanyIdGlobal");

                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.CreatedByName).HasMaxLength(500);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventContact>(entity =>
            {
                entity.Property(e => e.CreatedByName).HasMaxLength(500);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.FirstName).HasMaxLength(500);
                entity.Property(e => e.LastName).HasMaxLength(500);
                entity.Property(e => e.MiddleName).HasMaxLength(500);
            });

            modelBuilder.Entity<ExchangeSyncErrorLog>(entity =>
            {
                entity.ToTable("ExchangeSyncErrorLog");

                entity.HasIndex(e => e.UserId, "nci_wi_ExchangeSyncErrorLog_DE643C7EA3252838BE6DE320AD75587F");

                entity.Property(e => e.ErrorCode).HasMaxLength(50);
                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");
                entity.Property(e => e.RoutineType).HasMaxLength(100);
                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<ExchangeSyncLog>(entity =>
            {
                entity.ToTable("ExchangeSyncLog");

                entity.HasIndex(e => e.SubscriberId, "IX_ExchangeSyncLog_SubscriberId");

                entity.HasIndex(e => e.SyncDateTime, "IX_ExchangeSyncLog_SyncDateTime");

                entity.HasIndex(e => e.UserId, "IX_ExchangeSyncLog_UserId");

                entity.HasIndex(e => e.UserName, "IX_ExchangeSyncLog_UserName");

                entity.Property(e => e.SyncDateTime).HasColumnType("datetime");
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.HasKey(e => e.IndustryId).HasName("PK_tblIndustries");

                entity.HasIndex(e => e.IndustryName, "IX_Industries_IndustryName");

                entity.HasIndex(e => e.SubscriberId, "IX_Industries_SubscriberId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedByUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.IndustryName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Lane>(entity =>
            {
                entity.HasKey(e => e.LaneId).HasName("PK_tblOpportunityLanes");

                entity.HasIndex(e => e.Deleted, "nci_wi_Lanes_B158B2BE13ACA618FBDB72F7A49CD0C0");

                entity.HasIndex(e => new { e.DealId, e.Service }, "nci_wi_Lanes_DAD844CA60E491E389E96B81B88F4CB5");

                entity.Property(e => e.ConsigneeCompany).HasMaxLength(100);
                entity.Property(e => e.ConversionLaneDataCenter).HasMaxLength(50);
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
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.VolumeUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkCalendarEventToUser>(entity =>
            {
                entity.HasKey(e => e.LinkCalendarEventToUser1);

                entity.ToTable("LinkCalendarEventToUser");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkCalendarEventToUser_UserId");

                entity.Property(e => e.LinkCalendarEventToUser1).HasColumnName("LinkCalendarEventToUser");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.Subject).HasMaxLength(250);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkCompanyToCompany>(entity =>
            {
                entity.HasKey(e => e.LinkCompanyToCompanyId).HasName("PK_LinkCompanyCompany");

                entity.ToTable("LinkCompanyToCompany");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_LinkCompanyToCompany");

                entity.HasIndex(e => e.LinkedCompanyId, "IX_LinkCompanyToCompany_LinkedCompanyId");

                entity.HasIndex(e => e.LinkedCompanyIdGlobal, "IX_LinkCompanyToCompany_LinkedCompanyIdGlobal");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkCompanyToCompany_SubscriberId");

                entity.HasIndex(e => e.UserId, "IX_LinkCompanyToCompany_UserId");

                entity.HasIndex(e => e.UserName, "IX_LinkCompanyToCompany_UserName");

                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.LinkedCompanyName).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkContactToCompany>(entity =>
            {
                entity.HasKey(e => e.LinkContactToCompanyId).HasName("PK_LinkCompanyContact");

                entity.ToTable("LinkContactToCompany");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_LinkContactToCompany");

                entity.HasIndex(e => e.CompanyId, "IX_LinkContactToCompany_CompanyId");

                entity.HasIndex(e => e.ContactId, "IX_LinkContactToCompany_ContactId");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkContactToCompany_SubscriberId");

                entity.Property(e => e.CompanyName).HasMaxLength(100);
                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkContactToContact>(entity =>
            {
                entity.ToTable("LinkContactToContact");

                entity.HasIndex(e => e.Contact2Id, "IX_LinkContactToContact_Contact2Id");

                entity.HasIndex(e => e.ContactId, "IX_LinkContactToContact_ContactId");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkContactToDeal>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_DealLinkContact");

                entity.ToTable("LinkContactToDeal");

                entity.HasIndex(e => e.ContactId, "IX_LinkContactToDeal_ContactId");

                entity.HasIndex(e => e.DealId, "IX_LinkContactToDeal_DealId");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkContactToDeal_SubscriberId");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkUserToCompany>(entity =>
            {
                entity.ToTable("LinkUserToCompany");

                entity.HasIndex(e => e.CompanyId, "IX_LinkUserToCompany_CompanyId");

                entity.HasIndex(e => e.CompanyIdGlobal, "IX_LinkUserToCompany_CompanyIdGlobal");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkUserToCompany_SubscriberId");

                entity.HasIndex(e => e.UserId, "IX_LinkUserToCompany_UserId");

                entity.HasIndex(e => e.UserIdGlobal, "IX_LinkUserToCompany_UserIdGlobal");

                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserId).HasDefaultValueSql("((0))");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(50);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserDataCenter).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkUserToContact>(entity =>
            {
                entity.HasKey(e => e.LinkUserToContactId).HasName("PK_LinkContactToUser");

                entity.ToTable("LinkUserToContact");

                entity.HasIndex(e => new { e.ContactId, e.Deleted }, "nci_wi_LinkUserToContact_7814AEEB475A01C400DC616B7330EB1D");

                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.InviteAccepted).HasDefaultValueSql("((0))");
                entity.Property(e => e.InviteGuid).HasMaxLength(50);
                entity.Property(e => e.InviteStatus).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkUserToDeal>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_tblLinkUserToDeal");

                entity.ToTable("LinkUserToDeal");

                entity.HasIndex(e => e.DealId, "IX_LinkUserToDeal_DealId");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkUserToDeal_SubscriberId");

                entity.HasIndex(e => e.UserId, "IX_LinkUserToDeal_UserId");

                entity.HasIndex(e => new { e.UserId, e.Deleted }, "nci_wi_LinkUserToDeal_16C04D60383A45DCD1D406B103F6E7D6");

                entity.HasIndex(e => e.UserId, "nci_wi_LinkUserToDeal_49FB0D6E7E144545076DF6D06C4F0D80");

                entity.HasIndex(e => e.Deleted, "nci_wi_LinkUserToDeal_774788DC40049B00364F1C3D09EBF6A4");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserId).HasDefaultValueSql("((0))");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.InviteGuid).HasMaxLength(50);
                entity.Property(e => e.InviteStatus).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.LinkType).HasMaxLength(100);
                entity.Property(e => e.SalesTeamRole).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserDataCenter).HasMaxLength(50);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LinkUserToManager>(entity =>
            {
                entity.HasKey(e => e.LinkUserToManagerId).HasName("PK_tblLinkManagersSalesReps");

                entity.ToTable("LinkUserToManager");

                entity.HasIndex(e => e.ManagerUserId, "IX_LinkUserToManager_ManagerUserId");

                entity.HasIndex(e => e.SubscriberId, "IX_LinkUserToManager_SubscriberId");

                entity.HasIndex(e => e.UserId, "IX_LinkUserToManager_UserId");

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

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.CountryName, "IX_Locations_CountryName");

                entity.HasIndex(e => e.LocationName, "IX_Locations_LocationName");

                entity.HasIndex(e => e.SubscriberId, "IX_Locations_SubscriberId");

                entity.Property(e => e.Address).HasMaxLength(500);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.CountryCode).HasMaxLength(5);
                entity.Property(e => e.CountryName).HasMaxLength(100);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DistrictCode).HasMaxLength(20);
                entity.Property(e => e.DistrictName).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.Fax).HasMaxLength(30);
                entity.Property(e => e.Hours).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(100);
                entity.Property(e => e.LocationType).HasMaxLength(50);
                entity.Property(e => e.Phone).HasMaxLength(30);
                entity.Property(e => e.Phone2).HasMaxLength(30);
                entity.Property(e => e.Phone3).HasMaxLength(30);
                entity.Property(e => e.PostalCode).HasMaxLength(20);
                entity.Property(e => e.RegionCode).HasMaxLength(10);
                entity.Property(e => e.RegionId).HasDefaultValueSql("((0))");
                entity.Property(e => e.RegionName).HasMaxLength(100);
                entity.Property(e => e.StateProvince).HasMaxLength(50);
                entity.Property(e => e.TimeZone).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LostReason>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LostReasonName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NoteId).HasName("PK_tblNotes");

                entity.HasIndex(e => e.CompanyId, "IX_Notes_CompanyId");

                entity.HasIndex(e => e.ContactId, "IX_Notes_ContactId");

                entity.HasIndex(e => e.CreatedUserId, "IX_Notes_CreatedUserId");

                entity.HasIndex(e => e.DealId, "IX_Notes_DealId");

                entity.HasIndex(e => e.SubscriberId, "IX_Notes_SubscriberId");

                entity.HasIndex(e => e.Tags, "IX_Notes_Tags");

                entity.Property(e => e.Campaigns).HasMaxLength(1000);
                entity.Property(e => e.CompanyName).HasMaxLength(100);
                entity.Property(e => e.Competitors).HasMaxLength(1000);
                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserLocation).HasMaxLength(1000);
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DealTypes).HasMaxLength(1000);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("((0))")
                    .HasColumnType("datetime");
                entity.Property(e => e.NoteContent).HasMaxLength(4000);
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode, "IX_Quotes_CompanyCode");

                entity.HasIndex(e => e.CompanyId, "IX_Quotes_CompanyId");

                entity.HasIndex(e => e.CompanyName, "IX_Quotes_CompanyName");

                entity.HasIndex(e => e.DealId, "IX_Quotes_DealId");

                entity.HasIndex(e => e.QuoteCode, "IX_Quotes_QuoteCode");

                entity.HasIndex(e => e.QuoteStatus, "IX_Quotes_QuoteStatus");

                entity.HasIndex(e => e.SubscriberId, "IX_Quotes_SubscriberId");

                entity.Property(e => e.BranchCode).HasMaxLength(50);
                entity.Property(e => e.BranchName).HasMaxLength(100);
                entity.Property(e => e.CarrierVisibility).HasMaxLength(10);
                entity.Property(e => e.CompanyCode).HasMaxLength(50);
                entity.Property(e => e.CompanyDescription)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");
                entity.Property(e => e.CompanyName).HasMaxLength(50);
                entity.Property(e => e.ContactId).HasDefaultValueSql("((0))");
                entity.Property(e => e.ContactName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode).HasMaxLength(5);
                entity.Property(e => e.CurrencyName).HasMaxLength(5);
                entity.Property(e => e.CustomerCode).HasMaxLength(50);
                entity.Property(e => e.CustomerName).HasMaxLength(100);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
                entity.Property(e => e.Destination).HasMaxLength(500);
                entity.Property(e => e.DestinationIataCode).HasMaxLength(3);
                entity.Property(e => e.Incoterm).HasMaxLength(50);
                entity.Property(e => e.IncotermText).HasMaxLength(250);
                entity.Property(e => e.InternalNotes).HasMaxLength(4000);
                entity.Property(e => e.Language).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.Mode).HasMaxLength(50);
                entity.Property(e => e.NatureOfGoods).HasMaxLength(100);
                entity.Property(e => e.Origin).HasMaxLength(500);
                entity.Property(e => e.OriginIataCode).HasMaxLength(3);
                entity.Property(e => e.OriginSystem).HasMaxLength(50);
                entity.Property(e => e.PaymentConditions).HasMaxLength(250);
                entity.Property(e => e.ProfitGlobal).HasMaxLength(50);
                entity.Property(e => e.ProfitType).HasMaxLength(50);
                entity.Property(e => e.QuoteAmount).HasColumnType("money");
                entity.Property(e => e.QuoteCode).HasMaxLength(10);
                entity.Property(e => e.QuoteConditions).HasMaxLength(4000);
                entity.Property(e => e.QuoteDescription).HasMaxLength(100);
                entity.Property(e => e.QuoteNotes).HasMaxLength(4000);
                entity.Property(e => e.QuoteStatus).HasMaxLength(50);
                entity.Property(e => e.QuoteSubject).HasMaxLength(250);
                entity.Property(e => e.TotalCbms).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.TotalGrossWeight).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.TotalVolumetricWeight).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.TotalWeight).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.TransitTime).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserCode).HasMaxLength(50);
                entity.Property(e => e.UserEmail).HasMaxLength(100);
                entity.Property(e => e.UserIndoorCode).HasMaxLength(50);
                entity.Property(e => e.UserIndoorEmail).HasMaxLength(100);
                entity.Property(e => e.UserOutdoorCode).HasMaxLength(50);
                entity.Property(e => e.UserOutdoorEmail).HasMaxLength(100);
                entity.Property(e => e.ValidFom).HasColumnType("datetime");
                entity.Property(e => e.ValidTo).HasColumnType("datetime");
                entity.Property(e => e.WonOption).HasMaxLength(50);
            });

            modelBuilder.Entity<QuotePackage>(entity =>
            {
                entity.Property(e => e.Crated)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Forkliftable)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.PackageHeight).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.PackageLength).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.PackageWeight).HasColumnType("decimal(7, 2)");
                entity.Property(e => e.QuoteCode).HasMaxLength(50);
                entity.Property(e => e.Stackable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Turnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QuoteStatus>(entity =>
            {
                entity.ToTable("QuoteStatus");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.QuoteStatus1)
                    .HasMaxLength(50)
                    .HasColumnName("QuoteStatus");
                entity.Property(e => e.QuoteStatusCode).HasMaxLength(2);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionId).HasName("PK_tblRegions");

                entity.HasIndex(e => e.RegionName, "IX_Regions_RegionName");

                entity.HasIndex(e => e.SubscriberId, "IX_Regions_SubscriberId");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.RegionCode).HasMaxLength(8);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesManager>(entity =>
            {
                entity.Property(e => e.CountryCode).HasMaxLength(5);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.DistrictCode).HasMaxLength(20);
                entity.Property(e => e.DistrictName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LocationCode).HasMaxLength(20);
                entity.Property(e => e.LocationName).HasMaxLength(50);
                entity.Property(e => e.ManagerTitle).HasMaxLength(50);
                entity.Property(e => e.ManagerType).HasMaxLength(50);
                entity.Property(e => e.RegionCode).HasMaxLength(20);
                entity.Property(e => e.RegionName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);

                entity.HasOne(d => d.Subscriber).WithMany(p => p.SalesManagers)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_SalesManagers_SubscriberId");

                entity.HasOne(d => d.User).WithMany(p => p.SalesManagers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SalesManagers_UserId");
            });

            modelBuilder.Entity<SalesStage>(entity =>
            {
                entity.HasKey(e => e.SalesStageId).HasName("PK_tblOpportunitySalesStage");

                entity.HasIndex(e => e.SalesStageName, "IX_SalesStages_SalesStageName");

                entity.HasIndex(e => e.SortOrder, "IX_SalesStages_SortOrder");

                entity.HasIndex(e => e.SubscriberId, "IX_SalesStages_SubscriberId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.SalesStageName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.HasKey(e => e.SourceId).HasName("PK_tblLeadSource");

                entity.HasIndex(e => e.SourceName, "IX_Sources_SourceName");

                entity.HasIndex(e => e.SubscriberId, "IX_Sources_SubscriberId");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.SourceName).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.Property(e => e.SubscriberId).ValueGeneratedNever();
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Billable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.BillingCurrencyCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'US')");
                entity.Property(e => e.BillingCurrencySymbol)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'$')");
                entity.Property(e => e.BillingUserRate).HasColumnType("money");
                entity.Property(e => e.BillingUserReadOnlyRate).HasColumnType("money");
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.CompanyName).HasMaxLength(500);
                entity.Property(e => e.ContactName).HasMaxLength(100);
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
                entity.Property(e => e.SubscriberIpAddress).HasMaxLength(50);
                entity.Property(e => e.SyncServiceDomain).HasMaxLength(100);
                entity.Property(e => e.SyncServicePassword).HasMaxLength(500);
                entity.Property(e => e.SyncServiceUrl).HasMaxLength(100);
                entity.Property(e => e.SyncServiceUserName).HasMaxLength(50);
                entity.Property(e => e.SyncType).HasMaxLength(50);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserLimit).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.SortOrder, "IX_Tags_SortOrder");

                entity.HasIndex(e => e.SubscriberId, "IX_Tags_SubscriberId");

                entity.HasIndex(e => e.TagName, "IX_Tags_TagName");

                entity.HasIndex(e => e.UserId, "IX_Tags_UserId");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.TagName).HasMaxLength(20);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<FirstFreightAPI.Entities.DataCenter.Task>(entity =>
            {
                entity.HasIndex(e => e.DueDate, "IX_Tasks_DueDate");

                entity.HasIndex(e => e.SubscriberId, "IX_Tasks_SubscriberId");

                entity.HasIndex(e => e.TaskName, "IX_Tasks_TaskName");

                entity.HasIndex(e => e.UserId, "IX_Tasks_UserId");

                entity.HasIndex(e => new { e.DealId, e.Deleted, e.LastUpdate }, "nci_wi_Tasks_B4A032F27F304187A4D1D02FDCE1FD67");

                entity.Property(e => e.Campaigns).HasMaxLength(1000);
                entity.Property(e => e.CompanyIdGlobals).HasMaxLength(1000);
                entity.Property(e => e.CompanyIds).HasMaxLength(1000);
                entity.Property(e => e.CompanyName).HasMaxLength(100);
                entity.Property(e => e.CompanyNames).HasMaxLength(1000);
                entity.Property(e => e.Competitors).HasMaxLength(1000);
                entity.Property(e => e.ContactIds).HasMaxLength(1000);
                entity.Property(e => e.Contacts).HasMaxLength(1000);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DealName).HasMaxLength(100);
                entity.Property(e => e.DealTypes).HasMaxLength(1000);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(2000);
                entity.Property(e => e.DueDate).HasColumnType("date");
                entity.Property(e => e.ExchangeSyncId).HasMaxLength(200);
                entity.Property(e => e.ExchangeSyncLastModified).HasColumnType("datetime");
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.SourceDataCenter).HasMaxLength(50);
                entity.Property(e => e.StartDate).HasColumnType("date");
                entity.Property(e => e.Tags).HasMaxLength(200);
                entity.Property(e => e.TaskName).HasMaxLength(200);
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.UserLocation).HasMaxLength(1000);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TaskCompany>(entity =>
            {
                entity.HasIndex(e => e.CompanyIdGlobal, "IX_TaskCompanies_CompanyIdGlobal");

                entity.Property(e => e.CreatedByName).HasMaxLength(500);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskContact>(entity =>
            {
                entity.Property(e => e.CreatedByName).HasMaxLength(500);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.FirstName).HasMaxLength(500);
                entity.Property(e => e.LastName).HasMaxLength(500);
                entity.Property(e => e.MiddleName).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK_tblUsers");

                entity.HasIndex(e => new { e.ConversionSalesRepCode, e.SubscriberId }, "nci_wi_Users_99F74187685AB155829420A37803B12A");

                entity.HasIndex(e => e.ConversionUserId, "nci_wi_Users_E32BE232CA2686ED4CEB54C43D79C147");

                entity.Property(e => e.Address).HasMaxLength(500);
                entity.Property(e => e.AdminUser)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.BillingCode).HasMaxLength(50);
                entity.Property(e => e.BrowserName).HasMaxLength(50);
                entity.Property(e => e.BrowserVersion).HasMaxLength(50);
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.CompanyRoster)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.ConversionSalesRepCode).HasMaxLength(20);
                entity.Property(e => e.CountryCode).HasMaxLength(3);
                entity.Property(e => e.CountryName).HasMaxLength(50);
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'US')");
                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'$')");
                entity.Property(e => e.DataCenter).HasMaxLength(50);
                entity.Property(e => e.DateFormat)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'dd/mm/yyyy')");
                entity.Property(e => e.DateFormatReports)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'dd/MMM/yyyy')");
                entity.Property(e => e.DefaultReminderMinutes).HasDefaultValueSql("((15))");
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.DisplayLanguage)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'en-US')");
                entity.Property(e => e.DistrictCode).HasMaxLength(20);
                entity.Property(e => e.DistrictName).HasMaxLength(50);
                entity.Property(e => e.EmailActivityReminderMinutes).HasDefaultValueSql("((15))");
                entity.Property(e => e.EmailAddress).HasMaxLength(150);
                entity.Property(e => e.EmailDigest).HasMaxLength(20);
                entity.Property(e => e.EmailSummaryLastSent).HasColumnType("datetime");
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.FullName).HasMaxLength(100);
                entity.Property(e => e.GoogleCalendarEmail).HasMaxLength(100);
                entity.Property(e => e.GoogleRefreshToken).HasMaxLength(1000);
                entity.Property(e => e.GoogleSyncToken).HasMaxLength(1000);
                entity.Property(e => e.IpAddress).HasMaxLength(50);
                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'en-US')");
                entity.Property(e => e.LanguageName).HasMaxLength(50);
                entity.Property(e => e.LanguagesSpoken).HasMaxLength(150);
                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
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
                entity.Property(e => e.ReportDateFormat)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'dd/mmm/yyyy')");
                entity.Property(e => e.SalesRepCode).HasMaxLength(10);
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
                entity.Property(e => e.SyncType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Do Not Sync')");
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

            modelBuilder.Entity<UserActivationsDeactivation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_UserActivationHistory");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ActivatedByUserName).HasMaxLength(50);
                entity.Property(e => e.ActivatedDate).HasColumnType("datetime");
                entity.Property(e => e.DeactivatedByUserName).HasMaxLength(50);
                entity.Property(e => e.DeactivatedDate).HasColumnType("datetime");
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.ToTable("UserActivity");

                entity.HasIndex(e => e.CalendarEventId, "IX_UserActivity_CalendarEventId");

                entity.HasIndex(e => e.CompanyId, "IX_UserActivity_CompanyId");

                entity.HasIndex(e => e.ContactId, "IX_UserActivity_ContactId");

                entity.HasIndex(e => e.DealId, "IX_UserActivity_DealId");

                entity.HasIndex(e => e.NoteId, "IX_UserActivity_NoteId");

                entity.HasIndex(e => e.SubscriberId, "IX_UserActivity_SubscriberId");

                entity.HasIndex(e => e.TaskId, "IX_UserActivity_TaskId");

                entity.HasIndex(e => e.UserActivityTimestamp, "IX_UserActivity_UserActivityTimestamp");

                entity.HasIndex(e => e.UserId, "IX_UserActivity_UserId");

                entity.HasIndex(e => new { e.CompanyId, e.SubscriberId }, "nci_wi_UserActivity_6279B2037AA566DB5FED1A74CB4B7B80");

                entity.Property(e => e.CalendarEventSubject).HasMaxLength(200);
                entity.Property(e => e.CompanyName).HasMaxLength(200);
                entity.Property(e => e.ContactName).HasMaxLength(200);
                entity.Property(e => e.DealName).HasMaxLength(200);
                entity.Property(e => e.FilterName).HasMaxLength(50);
                entity.Property(e => e.NoteContent).HasMaxLength(4000);
                entity.Property(e => e.QuoteName).HasMaxLength(50);
                entity.Property(e => e.SubscriberName).HasMaxLength(200);
                entity.Property(e => e.TaskName).HasMaxLength(200);
                entity.Property(e => e.UserActivityMessage).HasMaxLength(4000);
                entity.Property(e => e.UserActivityTimestamp).HasColumnType("datetime");
                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<WonReason>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.CreatedUserName).HasMaxLength(50);
                entity.Property(e => e.DeletedDate).HasColumnType("datetime");
                entity.Property(e => e.DeletedUserName).HasMaxLength(50);
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.UpdateUserName).HasMaxLength(50);
                entity.Property(e => e.WonReasonName).HasMaxLength(50);
            });

        }
    }
}
