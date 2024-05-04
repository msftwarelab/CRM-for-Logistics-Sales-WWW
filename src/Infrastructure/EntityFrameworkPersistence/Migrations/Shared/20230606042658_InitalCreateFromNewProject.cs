using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.EntityFrameworkPersistence.Migrations.Shared
{
    /// <inheritdoc />
    public partial class InitalCreateFromNewProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AdminActiveOveride = table.Column<int>(type: "int", nullable: false),
                    AdminActiveOverideDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActivityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusyFree = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CalendarEventId = table.Column<int>(type: "int", nullable: false),
                    Campaigns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignIds = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryIds = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CompanySubscriberId = table.Column<int>(type: "int", nullable: false),
                    Competitors = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    CompletionPercent = table.Column<int>(type: "int", nullable: false),
                    ContactIds = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionActivityId = table.Column<int>(type: "int", nullable: false),
                    ConversionCreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConversionUpdatedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedUserLocation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DealIds = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DealNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "date", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((30))"),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EventSubject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EventTimeZone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EventType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExchangeAppointmentId = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ExchangeAppointmentItemId = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    ExchangeSyncId = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ExchangeSyncLastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    GoogleSyncId = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    GoogleSyncLastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: false),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NoteContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    NoteId = table.Column<int>(type: "int", nullable: false),
                    OriginSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OwnerUserId = table.Column<int>(type: "int", nullable: false),
                    OwnerUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    OwnerUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PublicPrivate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Reminder = table.Column<bool>(type: "bit", nullable: false),
                    ReminderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReminderIncrement = table.Column<int>(type: "int", nullable: true),
                    ReminderIncrementType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ReminderMinutes = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ReminderType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ReminderTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReoccurNumberOfTimes = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ReoccurrenceIncrement = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ReoccurrenceIncrementType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ReoccurrenceParentActivityId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SalesPurpose = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SalesStage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SavedAsActivity = table.Column<bool>(type: "bit", nullable: false),
                    SourceDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDataCenterCalendarEventId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SourceDataCenterNoteId = table.Column<int>(type: "int", nullable: false),
                    SourceDataCenterTaskId = table.Column<int>(type: "int", nullable: false),
                    SourceSubscriberId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyncType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserLocation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserTimeZone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UtcOffset = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActivityMembers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityMembersBak = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "ActivititesMembers",
                columns: table => new
                {
                    ActivityMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    AttendeeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactSubscriberId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InviteAccepted = table.Column<bool>(type: "bit", nullable: false),
                    InviteType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReminderJobId = table.Column<int>(type: "int", nullable: true),
                    ReminderSent = table.Column<bool>(type: "bit", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesMembers", x => x.ActivityMemberId);
                });

            migrationBuilder.CreateTable(
                name: "AdminUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forename = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AirportName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Continent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ElevationFeet = table.Column<int>(type: "int", nullable: true),
                    GpsCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IataCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    IdentifierCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    IsoRegion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    LocalCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Municipality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ScheduledService = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UrlHome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UrlWikipedia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAirports", x => x.AirportId);
                });

            migrationBuilder.CreateTable(
                name: "AsyncReportRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    RequestedBy = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ReportName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ExcelFileUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    JsonFileUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    JsonDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JSONFileContainerReference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    JSONFileBlobReference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    RefId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Error = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ElapsedTime = table.Column<int>(type: "int", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalCount = table.Column<int>(type: "int", nullable: false),
                    CompletedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsyncReportRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsyncThreads",
                columns: table => new
                {
                    AsyncThreadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Error = table.Column<bool>(type: "bit", nullable: false),
                    ErrorDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemsTotal = table.Column<int>(type: "int", nullable: false),
                    ItemsProcessed = table.Column<int>(type: "int", nullable: false),
                    ItemsSuccess = table.Column<int>(type: "int", nullable: false),
                    ItemsError = table.Column<int>(type: "int", nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    JobSubType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ResponseJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WorkflowAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsyncThreads", x => x.AsyncThreadId);
                });

            migrationBuilder.CreateTable(
                name: "BillingContacts",
                columns: table => new
                {
                    BillingContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingEntityId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    ToCc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsPrimaryContact = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberBillingContact", x => x.BillingContactId);
                });

            migrationBuilder.CreateTable(
                name: "BillingEntities",
                columns: table => new
                {
                    BillingEntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address01 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Billable = table.Column<bool>(type: "bit", nullable: false),
                    BillingCurrencyCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BillingCurrencySymbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BillingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingUserRate = table.Column<decimal>(type: "money", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    City = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoicePrefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    WithholdingTaxPercentage = table.Column<double>(type: "float", nullable: false),
                    Address02 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OutputFileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ShowBillingCodesOnExcelExport = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingEntities", x => x.BillingEntityId);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CampaignOwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampaignOwnerUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CampaignName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CampaignNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampaignStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampaignType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCampaigns", x => x.CampaignId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCompetitor",
                columns: table => new
                {
                    CompetitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Competitor = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Mode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    BusinessDetails = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCompetitor", x => x.CompetitorId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContactsImportRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanyOwnerId = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    TotalCount = table.Column<int>(type: "int", nullable: false),
                    CompletedCount = table.Column<int>(type: "int", nullable: false),
                    DuplicateCount = table.Column<int>(type: "int", nullable: false),
                    ErrorCount = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessDurationMS = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContactsImportRequest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyImportRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestUserId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CompanyOwnerId = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    CompletedCount = table.Column<int>(type: "int", nullable: false),
                    TotalCount = table.Column<int>(type: "int", nullable: false),
                    ErrorCount = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UploadFileContainerReference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UploadFileBlobReference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyImportRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyLanes",
                columns: table => new
                {
                    CompanyLaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedByIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DestinationCountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DestinationCountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DestinationIataCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DestinationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DestinationRegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DestinationRegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DestinationUnlocoCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Mode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OriginCountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OriginCountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OriginIataCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OriginName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OriginRegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OriginRegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OriginUnlocoCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Service = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShipperCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    TargetShippingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetVolumeAmount = table.Column<double>(type: "float", nullable: false),
                    TargetVolumeUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalShippingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalVolumeAmount = table.Column<double>(type: "float", nullable: false),
                    TotalVolumeUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequiredLT = table.Column<bool>(type: "bit", nullable: false),
                    IsIncumbent = table.Column<bool>(type: "bit", nullable: false),
                    IsTarget = table.Column<bool>(type: "bit", nullable: false),
                    Incumbent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RFQMonth = table.Column<int>(type: "int", nullable: false),
                    ContractStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContractEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AccountOwner = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ConsigneeCompany = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CurrentRate = table.Column<double>(type: "float", nullable: false),
                    Competitors = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FuelSurchargeIncluded = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyLanes", x => x.CompanyLaneId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyLinkTypes",
                columns: table => new
                {
                    CompanyLinkTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyLinkTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyLinkTypes_CompanyLinkTypeName", x => x.CompanyLinkTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyWarehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastUpdatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    WarehouseIncumbentOrTarget = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    WarehouseLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehouseSqMeters = table.Column<double>(type: "float", nullable: false),
                    WarehouseCategory = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWarehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    RegionContinent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Timezone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryDialingCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Country_ISO_Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DataCenter = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DateFormat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocalCurrencyCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    UpdatedName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CurrencyFormat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SubUnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubUnitRatio = table.Column<int>(type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCurrencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyExchangeRates",
                columns: table => new
                {
                    CurrencyExchangeRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ExchangeDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExchangeRate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCurrencyExchangeRates", x => x.CurrencyExchangeRateId);
                });

            migrationBuilder.CreateTable(
                name: "DealExchangeRateUpdateServiceLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsError = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DealsUpdated = table.Column<int>(type: "int", nullable: false),
                    ErrorDealsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealExchangeRateUpdateServiceLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CalendarEventId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DocumentBlobReference = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DocumentBlobContainer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentFolderId = table.Column<int>(type: "int", nullable: false),
                    DocumentGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    QuoteIdGlobal = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UploadedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UploadedUserId = table.Column<int>(type: "int", nullable: false),
                    UploadedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ConversionDocumentId = table.Column<int>(type: "int", nullable: false),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: true),
                    DocumentTypeText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeleteExisting = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    CcEmailAddresses = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Clicks = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    DealIdGlobal = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmailBodyHtml = table.Column<string>(type: "ntext", nullable: true),
                    EmailBodyText = table.Column<string>(type: "ntext", nullable: true),
                    EmailHeaders = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Error = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    FromEmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FromName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsError = table.Column<bool>(type: "bit", nullable: false),
                    MailboxHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MessageId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Opens = table.Column<int>(type: "int", nullable: false),
                    RecipientEmailAddresses = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ReplyToEmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ToEmail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SentByUserId = table.Column<int>(type: "int", nullable: true),
                    SentToUserId = table.Column<int>(type: "int", nullable: false),
                    SentToContactId = table.Column<int>(type: "int", nullable: false),
                    UtcSentDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    EmailTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateTypeId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRatesLog",
                columns: table => new
                {
                    ExchangeRatesLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElapsedTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ErrorMessage = table.Column<string>(type: "ntext", nullable: true),
                    RecordsAdded = table.Column<int>(type: "int", nullable: true),
                    RecordsDeleted = table.Column<int>(type: "int", nullable: true),
                    RecordsExported = table.Column<int>(type: "int", nullable: true),
                    RecordsUpdated = table.Column<int>(type: "int", nullable: true),
                    ReturnMessage = table.Column<string>(type: "ntext", nullable: true),
                    RoutineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RoutineType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Success = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRatesLog", x => x.ExchangeRatesLogId);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeServerTimezones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeServerTimeZone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TimeZoneDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeServerTimezones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeSyncErrorLog",
                columns: table => new
                {
                    ExchangeSyncErrorLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    ErrorCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ErrorDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeSyncErrorLog", x => x.ExchangeSyncErrorLogId);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeSyncLog",
                columns: table => new
                {
                    ExchangeSyncLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    SyncDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    SyncMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SyncType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeSyncLog", x => x.ExchangeSyncLogId);
                });

            migrationBuilder.CreateTable(
                name: "ForgotPasswordRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    DataCenter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Processed = table.Column<bool>(type: "bit", nullable: false),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForgotPasswordRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreeTrialRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DataCenter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailMessageId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Converted = table.Column<bool>(type: "bit", nullable: false),
                    ConvertedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FreeTrialCurrentStep = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeTrialRequets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalCompanies",
                columns: table => new
                {
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AdminOverideActive = table.Column<bool>(type: "bit", nullable: false),
                    AdminOverideActiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Campaigns = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Claimed = table.Column<bool>(type: "bit", nullable: false),
                    ClaimedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClaimedUserId = table.Column<int>(type: "int", nullable: false),
                    ClaimedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    ClaimedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyOwnerUserId = table.Column<int>(type: "int", nullable: false),
                    CompanyOwnerUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanySegmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CompanyTypes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreditLimit = table.Column<int>(type: "int", nullable: false),
                    DataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Division = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstShipmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GlobalCompanyOwnerGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    GlobalCompanyOwnerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Industries = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    LastCreditUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastShipmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LinkedUserEmails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LinkedUserNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NextActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PrimaryContactId = table.Column<int>(type: "int", nullable: false),
                    PrimaryGlobalContactId = table.Column<int>(type: "int", nullable: false),
                    SalesTeam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDataCenterCompanyId = table.Column<int>(type: "int", nullable: false),
                    SourceSubscriberId = table.Column<int>(type: "int", nullable: false),
                    StateProvince = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConversionAccountId = table.Column<int>(type: "int", nullable: false),
                    ConversionLeadId = table.Column<int>(type: "int", nullable: false),
                    ConversionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataCenterConversionAddedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataCenterConversionUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GlobalCompanyOwnerGlobalUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Competitors = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ParentCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConversionGlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    ConversionGlobalCompanyDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StrategicSalesPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentYearAirTonnageTotal = table.Column<double>(type: "float", nullable: false),
                    CurrentYearAirTonnageShare = table.Column<double>(type: "float", nullable: false),
                    NextYearAirTonnageObjective = table.Column<double>(type: "float", nullable: false),
                    CurrentYearOceanTEUTotal = table.Column<double>(type: "float", nullable: false),
                    CurrentYearOceanTEUShare = table.Column<double>(type: "float", nullable: false),
                    NextYearOceanTEUObjective = table.Column<double>(type: "float", nullable: false),
                    MajorProducts = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DigitalAddress = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalCompanies", x => x.GlobalCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalCompanyAccessRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RequestedGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyOwnerId = table.Column<int>(type: "int", nullable: false),
                    Accepted = table.Column<bool>(type: "bit", nullable: false),
                    AcceptedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GlobalCompanyAccessRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalContacts",
                columns: table => new
                {
                    GlobalContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    BirthdayDay = table.Column<int>(type: "int", nullable: false),
                    BirthdayMonth = table.Column<int>(type: "int", nullable: false),
                    BusinessAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BusinessCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessPhone = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BusinessPhone2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BusinessStateProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessPostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChildrenNames = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ContactOwnerUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    ContactSource = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ContactType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ExchangeContactId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ExchangeSyncLastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GoogleContactId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GoogleSyncLastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HolidayCards = table.Column<bool>(type: "bit", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HomeCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HomeCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    HomeStateProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HomePostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MobilePhone = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    NextActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OriginSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrivateContact = table.Column<bool>(type: "bit", nullable: false),
                    ReceiveEmail = table.Column<bool>(type: "bit", nullable: false),
                    RelatedContacts = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SpouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SyncType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConversionContactId = table.Column<int>(type: "int", nullable: true),
                    SalesTeam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DecisionRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampaignName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Married = table.Column<bool>(type: "bit", nullable: false),
                    HasChildern = table.Column<bool>(type: "bit", nullable: false),
                    OkToCall = table.Column<bool>(type: "bit", nullable: false),
                    FormerEmployee = table.Column<bool>(type: "bit", nullable: false),
                    PreviousEmployees = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DigitalAddress = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalContacts", x => x.GlobalContactId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalDeals",
                columns: table => new
                {
                    DealIdGlobal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Campaign = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CBMs = table.Column<double>(type: "float", nullable: false),
                    CBMsSpot = table.Column<double>(type: "float", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commodities = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Competitors = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CommissionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CommissionStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConsigneeNames = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContractStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateLost = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateProposalDue = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateWon = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataCenter = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DealCountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DealDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    DealName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DealNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DealOwnerUserId = table.Column<int>(type: "int", nullable: false),
                    DealOwnerIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DealOwnerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DealType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DecisionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DestinationLocations = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    DestinationCountries = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    DestinationRegions = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DealSource = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EstimatedStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Incoterms = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Kgs = table.Column<double>(type: "float", nullable: false),
                    KgsSpot = table.Column<double>(type: "float", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Lbs = table.Column<double>(type: "float", nullable: false),
                    LbsSpot = table.Column<double>(type: "float", nullable: false),
                    LocationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NextActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrignLocations = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    OrignCountries = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    OrignRegions = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    PrimaryContactId = table.Column<int>(type: "int", nullable: false),
                    PrimaryContactName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Profit = table.Column<double>(type: "float", nullable: false),
                    ProfitPercentage = table.Column<double>(type: "float", nullable: false),
                    ProfitUSDSpot = table.Column<double>(type: "float", nullable: false),
                    ProfitUSD = table.Column<double>(type: "float", nullable: false),
                    ReasonWonLost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    RevenueUSD = table.Column<double>(type: "float", nullable: false),
                    RevenueUSDSpot = table.Column<double>(type: "float", nullable: false),
                    SalesStageId = table.Column<int>(type: "int", nullable: false),
                    SalesStageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesTeam = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Services = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ShipperNames = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    SourceDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDataCenterDealId = table.Column<int>(type: "int", nullable: true),
                    SourceSubscriberId = table.Column<int>(type: "int", nullable: true),
                    SpotDeal = table.Column<bool>(type: "bit", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TEUs = table.Column<double>(type: "float", nullable: false),
                    TEUsSpot = table.Column<double>(type: "float", nullable: false),
                    Tonnes = table.Column<double>(type: "float", nullable: false),
                    TonnesSpot = table.Column<double>(type: "float", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WonExchangeRate = table.Column<double>(type: "float", nullable: false),
                    TransferredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEUs = table.Column<double>(type: "float", nullable: false),
                    FEUsSpot = table.Column<double>(type: "float", nullable: false),
                    Trucks = table.Column<double>(type: "float", nullable: false),
                    TrucksSpot = table.Column<double>(type: "float", nullable: false),
                    LastExchangeRateAppliedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConversionGlobalDealId = table.Column<int>(type: "int", nullable: false),
                    ConversionGlobalDealDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryContactIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CopiedGlobalDealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalDeals_DealIdGlobal", x => x.DealIdGlobal);
                });

            migrationBuilder.CreateTable(
                name: "GlobalLanes",
                columns: table => new
                {
                    LaneId = table.Column<int>(type: "int", nullable: false),
                    GlobalLaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalDealId = table.Column<int>(type: "int", nullable: false),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedById = table.Column<int>(type: "int", nullable: false),
                    DeletedByIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DestinationCountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DestinationCountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DestinationIataCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DestinationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DestinationRegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DestinationRegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DestinationUnlocoCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Mode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OriginCountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OriginCountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OriginIataCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OriginName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OriginRegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OriginRegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OriginUnlocoCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerAtDestination = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerDestinationCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerDestinationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PartnerDestinationContact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerDestinationCountryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerDestinationEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerDestinationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerDestinationNameOther = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerDestinationPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerAtOrigin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerOriginCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerOriginCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PartnerOriginContact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerOriginCountryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerOriginEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PartnerOriginName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerOriginNameOther = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PartnerOriginPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProfitAmount = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0.0))"),
                    ProfitPercent = table.Column<double>(type: "float", nullable: false),
                    ProfitUnitOfMeasure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShipperCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShippingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalLaneProfit = table.Column<double>(type: "float", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    VolumeAmount = table.Column<double>(type: "float", nullable: false),
                    VolumeUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RevenueUSD = table.Column<double>(type: "float", nullable: false),
                    TotalLaneProfitUSD = table.Column<double>(type: "float", nullable: false),
                    ReceiveFrom3PL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SpecialRequirements = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RequiresBarcode = table.Column<bool>(type: "bit", nullable: false),
                    TrackAndTrace = table.Column<bool>(type: "bit", nullable: false),
                    CustomerPickUpAtWarehouse = table.Column<bool>(type: "bit", nullable: false),
                    TransferredDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDealGlobalLanes", x => x.LaneId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalLocations",
                columns: table => new
                {
                    GlobalLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airport = table.Column<bool>(type: "bit", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IataCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    InlandPort = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LocationCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MultiModal = table.Column<bool>(type: "bit", nullable: false),
                    RoadTerminal = table.Column<bool>(type: "bit", nullable: false),
                    RailTerminal = table.Column<bool>(type: "bit", nullable: false),
                    SeaPort = table.Column<bool>(type: "bit", nullable: false),
                    UnlocoCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalLocations", x => x.GlobalLocationId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalQuotes",
                columns: table => new
                {
                    QuoteIdGlobal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true),
                    DealIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OwnerUserId = table.Column<int>(type: "int", nullable: false),
                    OwnerUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    OwnerUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuoteName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuoteAmount = table.Column<decimal>(type: "money", nullable: true),
                    QuoteCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuoteConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuoteNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuoteValidFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuoteValidTo = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContactIdGlobal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalQuotes", x => x.QuoteIdGlobal);
                });

            migrationBuilder.CreateTable(
                name: "GlobalUserActivationsDeactivations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    ActivatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ActivatedByUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActivatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeactivatedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeactivatedByUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeactivatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivationHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GlobalUserActivity",
                columns: table => new
                {
                    GlobalUserActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    ActivityType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    ContactSubscriberId = table.Column<int>(type: "int", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LogData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalDealId = table.Column<int>(type: "int", nullable: true),
                    DealName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FilterId = table.Column<int>(type: "int", nullable: true),
                    FilterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoteContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    QuoteIdGlobal = table.Column<int>(type: "int", nullable: true),
                    QuoteName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    SubscriberName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserActivityMessage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    UserActivityTimestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserActivityId = table.Column<int>(type: "int", nullable: true),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.GlobalUserActivityId);
                });

            migrationBuilder.CreateTable(
                name: "GlobalUsers",
                columns: table => new
                {
                    GlobalUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AdminUser = table.Column<bool>(type: "bit", nullable: false),
                    AllowSubscriberCommission = table.Column<bool>(type: "bit", nullable: false),
                    BillingCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingEntityId = table.Column<int>(type: "int", nullable: false),
                    BrowserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BrowserVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateFormat = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateFormatReports = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DisplayLanguage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmailDigest = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguagesSpoken = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LocationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoginEnabled = table.Column<bool>(type: "bit", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PhoneExtension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Preferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Quoting = table.Column<bool>(type: "bit", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ScreenResolution = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignatureImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SignatureText = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TimeZoneCityNames = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeZoneExchange = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TimeZoneOffset = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserActivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserDeactivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserRoles = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserGuid = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    ConversionUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DefaultReminderMinutes = table.Column<int>(type: "int", nullable: false),
                    DistrictCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailSummaryDaily = table.Column<bool>(type: "bit", nullable: false),
                    EmailSummaryLastSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmailActivityReminders = table.Column<bool>(type: "bit", nullable: false),
                    EmailActivityReminderMinutes = table.Column<int>(type: "int", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GoogleCalendarEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SyncPasswordHashed = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GoogleRefreshToken = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GoogleSyncToken = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginFailures = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PasswordHashed = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyncOnlyCrmCategoryItems = table.Column<bool>(type: "bit", nullable: false),
                    SyncAppointmentsLastDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncContactsLastDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SyncPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyncState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyncTasksLastDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SyncIsLegacy = table.Column<bool>(type: "bit", nullable: false),
                    SyncUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Version = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CustomerProfileActive = table.Column<bool>(type: "bit", nullable: false),
                    VisitReportEnabled = table.Column<bool>(type: "bit", nullable: false),
                    WorkflowEnabled = table.Column<bool>(type: "bit", nullable: false),
                    WorkflowSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnableO365Sync = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalUsers", x => x.GlobalUserId);
                });

            migrationBuilder.CreateTable(
                name: "GoogleSyncErrorLog",
                columns: table => new
                {
                    GoogleSyncErrorLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorCode = table.Column<int>(type: "int", nullable: true),
                    ErrorDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ErrorMessage = table.Column<string>(type: "ntext", nullable: true),
                    GoogleSyncLogId = table.Column<int>(type: "int", nullable: true),
                    ReturnMessage = table.Column<string>(type: "ntext", nullable: true),
                    RoutineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RoutineType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleSyncErrorLog", x => x.GoogleSyncErrorLogId);
                });

            migrationBuilder.CreateTable(
                name: "GoogleSyncLog",
                columns: table => new
                {
                    GoogleSyncLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentsAddedToCrm = table.Column<int>(type: "int", nullable: true),
                    AppointmentsAddedToSync = table.Column<int>(type: "int", nullable: true),
                    AppointmentsUpdatedInCrm = table.Column<int>(type: "int", nullable: true),
                    AppointmentsUpdatedInSync = table.Column<int>(type: "int", nullable: true),
                    ContactsAddedToCrm = table.Column<int>(type: "int", nullable: true),
                    ContactsAddedToSync = table.Column<int>(type: "int", nullable: true),
                    ContactsUpdatedInCrm = table.Column<int>(type: "int", nullable: true),
                    ContactsUpdatedInSync = table.Column<int>(type: "int", nullable: true),
                    ContactsDeletedInSync = table.Column<int>(type: "int", nullable: true),
                    ContactsDeletedInCrm = table.Column<int>(type: "int", nullable: true),
                    ElapsedTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TasksAddedToCrm = table.Column<int>(type: "int", nullable: true),
                    TasksAddedToSync = table.Column<int>(type: "int", nullable: true),
                    TasksUpdatedInCrm = table.Column<int>(type: "int", nullable: true),
                    TasksUpdatedInSync = table.Column<int>(type: "int", nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    SyncEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGoogleSyncLog", x => x.GoogleSyncLogId);
                });

            migrationBuilder.CreateTable(
                name: "Incoterms",
                columns: table => new
                {
                    IncotermId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Incoterm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CarrierLoadOnTruck = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExportCustomsDeclaration = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CarriageToPortOfExport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UnloadTruckInPortOfExport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LoadingChargesInPortOfExport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CarriageToPortOfImport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UnloadingChargesInPortOfImport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LoadingOnTruckInPortOfIimport = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CarriageToPlaceOfDestination = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Insurance = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ImportCustomsClearance = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ImportTaxes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incoterms", x => x.IncotermId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceActiveUsers",
                columns: table => new
                {
                    InvoiceActiveUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    BillingCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedById = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    InvoiceMonth = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceYear = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberCompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserActivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserBilledAmount = table.Column<double>(type: "float", nullable: false),
                    UserDeactivationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceActiveUsers", x => x.InvoiceActiveUserId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceContacts",
                columns: table => new
                {
                    InvoiceContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    BillingContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceContact", x => x.InvoiceContactId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceEmail",
                columns: table => new
                {
                    InvoiceEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    EmailBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SentBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceEmail", x => x.InvoiceEmailId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    BillingEntityId = table.Column<int>(type: "int", nullable: false),
                    AddressBlock = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BillingContactId = table.Column<int>(type: "int", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedById = table.Column<int>(type: "int", nullable: false),
                    ExcelUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceAmount = table.Column<double>(type: "float", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InvoiceGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceMonth = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceYear = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MonthlyUserFee = table.Column<double>(type: "float", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PdfUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WithholdingTaxPercentage = table.Column<double>(type: "float", nullable: false),
                    WithholdingTaxAmount = table.Column<double>(type: "float", nullable: false),
                    ExcelDocumentId = table.Column<int>(type: "int", nullable: false),
                    PdfDocumentId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSent",
                columns: table => new
                {
                    InvoiceSentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    BillingContactId = table.Column<int>(type: "int", nullable: false),
                    InvoiceEmailId = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SentBy = table.Column<int>(type: "int", nullable: false),
                    ToCcBcc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSent", x => x.InvoiceSentId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    InvoiceStatusId = table.Column<int>(type: "int", nullable: false),
                    InvoiceStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.InvoiceStatusId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatusHistory",
                columns: table => new
                {
                    InvoiceStatusHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatusHistory", x => x.InvoiceStatusHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePhrases",
                columns: table => new
                {
                    LanguagePhraseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedByUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguagePhrase = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguagePhrases", x => x.LanguagePhraseId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageTranslations",
                columns: table => new
                {
                    LanguageTranslationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguagePhrase = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Translation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedUserId = table.Column<int>(type: "int", nullable: true),
                    VerifiedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguageTranslations", x => x.LanguageTranslationId);
                });

            migrationBuilder.CreateTable(
                name: "LinkActivityToDeal",
                columns: table => new
                {
                    LinkActivityToDealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    DealIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DealName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DealSubscriberId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkActivityToDeal", x => x.LinkActivityToDealId);
                });

            migrationBuilder.CreateTable(
                name: "LinkCompanyToCompany",
                columns: table => new
                {
                    LinkCompanyToCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LinkedCompanyIdGlobal = table.Column<int>(type: "int", nullable: false),
                    LinkedCompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LinkTypeId = table.Column<int>(type: "int", nullable: false),
                    LinkTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerApproved = table.Column<bool>(type: "bit", nullable: false),
                    OwnerApprovalStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OwnerApprovalGuid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkCompanyCompany", x => x.LinkCompanyToCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "LinkCountryRegion",
                columns: table => new
                {
                    LinkCountryRegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkCountryRegion", x => x.LinkCountryRegionId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalCompanyGlobalUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    GlobalCompanyName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GlobalUserId = table.Column<int>(type: "int", nullable: false),
                    GlobalUserName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CompanySubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserSubscriberId = table.Column<int>(type: "int", nullable: false),
                    SalesTeamRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LinkType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateUserName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InviteAccepted = table.Column<bool>(type: "bit", nullable: false),
                    InviteStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InviteGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGlobalCompanyGlobalUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalContactToCompany",
                columns: table => new
                {
                    LinkGlobalContactToCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    GlobalCompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LinkType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGlobalContactToCompany", x => x.LinkGlobalContactToCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalContactToDeal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    GlobalDealId = table.Column<int>(type: "int", nullable: false),
                    DealName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LinkType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalDealLinkContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalDealGlobalUser",
                columns: table => new
                {
                    LinkGloablDealGlobalUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DealSubscriberId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GlobalDealId = table.Column<int>(type: "int", nullable: false),
                    GlobalDealName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GlobalUserId = table.Column<int>(type: "int", nullable: false),
                    GlobalUserName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InviteAccepted = table.Column<bool>(type: "bit", nullable: false),
                    InviteGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InviteStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LinkType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SalesTeamRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserSubscriberId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGlobalDealGlobalUser", x => x.LinkGloablDealGlobalUserId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalSuscriberToSubscriber",
                columns: table => new
                {
                    LinkGlobalSubscriberToSubscriberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalSubscriberId = table.Column<int>(type: "int", nullable: false),
                    LinkedSubscriberId = table.Column<int>(type: "int", nullable: false),
                    DataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_1", x => x.LinkGlobalSubscriberToSubscriberId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalUserToGlobalContact",
                columns: table => new
                {
                    LinkUserToGlobalContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    GlobalContactId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LinkType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalesTeamRole = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InviteAccepted = table.Column<bool>(type: "bit", nullable: false),
                    InviteStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InviteGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserSubscriberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGlobalUserToGlobalContact", x => x.LinkUserToGlobalContactId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalUserToGlobalManager",
                columns: table => new
                {
                    LinkGlobalUserToGlobalManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ManagerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ManagerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ManagerGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    ManagerGlobalUserSubscriberId = table.Column<int>(type: "int", nullable: false),
                    GlobalUserId = table.Column<int>(type: "int", nullable: false),
                    GlobalUserSubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateGlobalUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLinkManagersSalesReps", x => x.LinkGlobalUserToGlobalManagerId);
                });

            migrationBuilder.CreateTable(
                name: "LinkGlobalUserToManagingCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalUserId = table.Column<int>(type: "int", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGlobalUserToManagingCountry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MessageFilterDealId = table.Column<int>(type: "int", nullable: true),
                    MessageFilterCompanyIdGlobal = table.Column<int>(type: "int", nullable: true),
                    MessageFilterContactId = table.Column<int>(type: "int", nullable: true),
                    MessageFilterData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageContentType = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MessageEmailData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageToUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    MessageToUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MessageCCGlobalUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageSentDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MessageSentDeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MessageSentDeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    MessageSentDeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MessageReceviedDeletedGlobalUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MessageFilterGlobalContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "OutlookCategoryColors",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HexColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RGB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutlookCategoryColors", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ReassignUserRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartingUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    NewUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CurrentProcessingType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    RequestedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CompaniesFound = table.Column<int>(type: "int", nullable: false),
                    CompaniesTransferred = table.Column<int>(type: "int", nullable: false),
                    ContactsFound = table.Column<int>(type: "int", nullable: false),
                    ContactsTransferred = table.Column<int>(type: "int", nullable: false),
                    EventsFound = table.Column<int>(type: "int", nullable: false),
                    EventsTransferred = table.Column<int>(type: "int", nullable: false),
                    TasksFound = table.Column<int>(type: "int", nullable: false),
                    TasksTransferred = table.Column<int>(type: "int", nullable: false),
                    DealsFound = table.Column<int>(type: "int", nullable: false),
                    DealsTransferred = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReassignUserRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegionManagerUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    RegionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRegions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "ReportFilters",
                columns: table => new
                {
                    FilterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FilterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFilters", x => x.FilterId);
                });

            migrationBuilder.CreateTable(
                name: "SalesTeamRoles",
                columns: table => new
                {
                    SalesTeamRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SalesTeamRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTeamRoleId", x => x.SalesTeamRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AirVolumeDisplay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AllowSubscriberCommission = table.Column<bool>(type: "bit", nullable: false),
                    Billable = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BillingCurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true, defaultValueSql: "(N'US')"),
                    BillingCurrencySymbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true, defaultValueSql: "(N'$')"),
                    BillingUserRate = table.Column<decimal>(type: "money", nullable: true),
                    BillingUserReadOnlyRate = table.Column<decimal>(type: "money", nullable: true),
                    BillingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CompanyCodeText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyParentCodeText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'United States')"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CrmAdminEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DefaultDateFormat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'dd/mm/yyyy')"),
                    DefaultLeadResponseDays = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    DefaultReportCurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "(N'US')"),
                    DefaultReportDateFormat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'dd/mmm/yyyy')"),
                    DefaultShippingFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'Per Year')"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailDisclaimer = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    EmailFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExchangeDomain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExchangeServerTimeZone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExchangeUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FreeTrial = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LogonUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Quoting = table.Column<bool>(type: "bit", nullable: false),
                    SsoApiKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubDomain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberApiKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SubscriberIpAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscriberType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SyncType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SyncServiceDomain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SyncServicePassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyncServiceUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SyncServiceUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserLimit = table.Column<int>(type: "int", nullable: false),
                    ConversionSubscriberId = table.Column<int>(type: "int", nullable: false),
                    ConversionDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerProfileActive = table.Column<bool>(type: "bit", nullable: false),
                    ShowBillingCodesOnExcelExport = table.Column<bool>(type: "bit", nullable: false),
                    IsDemo = table.Column<bool>(type: "bit", nullable: false),
                    DisplayTotalsValueFrequency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberTransfer",
                columns: table => new
                {
                    SubscriberTransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DestinationSubscriberId = table.Column<int>(type: "int", nullable: false),
                    DestinationDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnabledUsers = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceSubscriberId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    TransferredAdminUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberTransfer", x => x.SubscriberTransferId);
                });

            migrationBuilder.CreateTable(
                name: "SwitchUserRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SwitchDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsLoggedIn = table.Column<bool>(type: "bit", nullable: false),
                    AdminUserId = table.Column<int>(type: "int", nullable: false),
                    SwitchToGlobalUserId = table.Column<int>(type: "int", nullable: false),
                    Expired = table.Column<bool>(type: "bit", nullable: false),
                    SwitchToGlobalUserDataCenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwitchUserSession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableStatus",
                columns: table => new
                {
                    TableStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableStatus", x => x.TableStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    TextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    ActivitiesMemberId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsError = table.Column<bool>(type: "bit", nullable: false),
                    ErrorDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TextType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TextTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TextToName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TextToUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    TextToContactId = table.Column<int>(type: "int", nullable: true),
                    TextFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TextFromUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TextFromUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    TextMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwillioSid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.TextId);
                });

            migrationBuilder.CreateTable(
                name: "TimeZones",
                columns: table => new
                {
                    TimeZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityNames = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    TimeZoneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TimeZoneIANA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UtcOffset = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EnumTimeZoneID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZones", x => x.TimeZoneId);
                });

            migrationBuilder.CreateTable(
                name: "TimeZonesDaylightSavings",
                columns: table => new
                {
                    TimeZonesDaylightSavingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DstStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DstEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TimeZoneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeZoneFullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TimeZoneYear = table.Column<int>(type: "int", nullable: false),
                    UtcOffset = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZones_DST1", x => x.TimeZonesDaylightSavingsId);
                });

            migrationBuilder.CreateTable(
                name: "UnlocoCodes",
                columns: table => new
                {
                    UnlocoCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnlocoCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Airport = table.Column<bool>(type: "bit", nullable: false),
                    BorderCrossing = table.Column<bool>(type: "bit", nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FixedTransport = table.Column<bool>(type: "bit", nullable: false),
                    FunctionNotKnown = table.Column<bool>(type: "bit", nullable: false),
                    IataCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InlandPort = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocationDate = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    LocationFunction = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocationNameWithDiacriticals = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Multimodal = table.Column<bool>(type: "bit", nullable: false),
                    PostalExchangeOffice = table.Column<bool>(type: "bit", nullable: false),
                    RailTerminal = table.Column<bool>(type: "bit", nullable: false),
                    RoadTerminal = table.Column<bool>(type: "bit", nullable: false),
                    Seaport = table.Column<bool>(type: "bit", nullable: false),
                    SubdivisionCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MatchesPortCode = table.Column<bool>(type: "bit", nullable: false),
                    PortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNLocoCodes", x => x.UnlocoCodeId);
                });

            migrationBuilder.CreateTable(
                name: "UserEmailLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    UserSubscriberId = table.Column<int>(type: "int", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmailLinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "WebAppErrors",
                columns: table => new
                {
                    WebAppErrorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorCallStack = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ErrorCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ErrorDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    PageCalledFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoutineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    SubscriberName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebAppErrors", x => x.WebAppErrorId);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowAccountEvents",
                columns: table => new
                {
                    WorkflowAccountEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastWebhookStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastWebhookDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NylasEventId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JobStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    JobStatusType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    JobStatusId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JobStatusStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WorkflowAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowAccountEvents", x => x.WorkflowAccountEventId);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowAccounts",
                columns: table => new
                {
                    WorkflowAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    UserIdGlobal = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserIdGlobal = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ErrorDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NylasAccountId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NylasAccessToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NylasProvider = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NylasEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NylasCalendarId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NylasConnectedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Settings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "(N'added')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowAccounts", x => x.WorkflowAccountId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberTransferStep",
                columns: table => new
                {
                    SubscriberTransferStepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberTransferId = table.Column<int>(type: "int", nullable: false),
                    Step = table.Column<int>(type: "int", nullable: false),
                    StepStr = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StartedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalFound = table.Column<int>(type: "int", nullable: false),
                    TotalTransferredCount = table.Column<int>(type: "int", nullable: false),
                    ErrorCount = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberTransferStep", x => x.SubscriberTransferStepId);
                    table.ForeignKey(
                        name: "FK_SubscriberTransferStep_SubscriberTransferStep",
                        column: x => x.SubscriberTransferId,
                        principalTable: "SubscriberTransfer",
                        principalColumn: "SubscriberTransferId");
                });

            migrationBuilder.CreateTable(
                name: "SubscriberTransferStepError",
                columns: table => new
                {
                    SubscriberTransferStepErrorId = table.Column<int>(type: "int", nullable: false),
                    SubscriberTransferStepId = table.Column<int>(type: "int", nullable: false),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefId = table.Column<int>(type: "int", nullable: false),
                    RefType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberTransferStepError", x => x.SubscriberTransferStepErrorId);
                    table.ForeignKey(
                        name: "FK_SubscriberTransferStepError_SubscriberTransferStep",
                        column: x => x.SubscriberTransferStepId,
                        principalTable: "SubscriberTransferStep",
                        principalColumn: "SubscriberTransferStepId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ActivityType",
                table: "Activities",
                column: "ActivityType");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CompanyIdGlobal",
                table: "Activities",
                column: "CompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CreatedDate",
                table: "Activities",
                column: "CreatedDate");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_OwnerUserIdGlobal",
                table: "Activities",
                column: "OwnerUserIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_StartDateTime",
                table: "Activities",
                column: "StartDateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_SubscriberId",
                table: "Activities",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserIdGlobal",
                table: "Activities",
                column: "UserIdGlobal");

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_034A33AF9C941C20DC903A096A5D1BD1",
                table: "Activities",
                column: "CalendarEventId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_5EE6EC992714D949547770F0BEC2604F",
                table: "Activities",
                columns: new[] { "ActivityType", "CompanyIdGlobal", "DealIds" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_9A92EBAE67E56EC9CD0DEE58DD8C8E8A",
                table: "Activities",
                columns: new[] { "OwnerUserId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_A786A3316486AF61B2D0AB5E8F648DBB",
                table: "Activities",
                columns: new[] { "CompanyIdGlobal", "Completed" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_CFEE88E841BF6436C62169C82F36B330",
                table: "Activities",
                columns: new[] { "GoogleSyncId", "ReoccurrenceParentActivityId", "ActivityId" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_DC83C1E827957C6F85D857CBE7D7FD57",
                table: "Activities",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_EAC44CF7B75B04F6774309B829C6C640",
                table: "Activities",
                columns: new[] { "OwnerUserIdGlobal", "Completed" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_F5D8559C415D5CFCCDE6D6FA27C8E71F",
                table: "Activities",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_Activities_F87577D8C9538AE640A8761647FDF120",
                table: "Activities",
                column: "CreatedDate");

            migrationBuilder.CreateIndex(
                name: "IX_ActivititesMembers_ActivityId",
                table: "ActivititesMembers",
                column: "ActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivititesMembers_ContactId",
                table: "ActivititesMembers",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivititesMembers_Email",
                table: "ActivititesMembers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_ActivititesMembers_SubscriberId",
                table: "ActivititesMembers",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivititesMembers_UserIdGlobal",
                table: "ActivititesMembers",
                column: "UserIdGlobal");

            migrationBuilder.CreateIndex(
                name: "nci_wi_ActivititesMembers_5CCF269F1239B435B842295700B778D7",
                table: "ActivititesMembers",
                columns: new[] { "UserId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_ActivititesMembers_C13E92456DB2B53673DE2C49D9624834",
                table: "ActivititesMembers",
                columns: new[] { "UserIdGlobal", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_ActivititesMembers_FB61BE8B46C32FAFFE269EBC7292E6A0",
                table: "ActivititesMembers",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_AirportName",
                table: "Airports",
                column: "AirportName");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CountryCode",
                table: "Airports",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_IATA_Code",
                table: "Airports",
                column: "IataCode");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryCode",
                table: "Countries",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryName",
                table: "Countries",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "nci_wi_CurrencyExchangeRates_EDAD6F45D4D02C076C9C58D13BD92575",
                table: "CurrencyExchangeRates",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "nci_wi_Documents_12BC7D2D8FF84EFB343AFB585EAF55FF",
                table: "Documents",
                columns: new[] { "DocumentType", "UserIdGlobal", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_Documents_AA5E7D39B0953BDDB156723EC9BBF2CA",
                table: "Documents",
                columns: new[] { "CompanyIdGlobal", "DocumentType", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_CompanyId",
                table: "Emails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_CompanyIdGlobal",
                table: "Emails",
                column: "CompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ContactId",
                table: "Emails",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_DealId",
                table: "Emails",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_DealIdGlobal",
                table: "Emails",
                column: "DealIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_SubscriberId",
                table: "Emails",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_Active",
                table: "GlobalCompanies",
                column: "Active");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_CompanyId",
                table: "GlobalCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_CompanyName",
                table: "GlobalCompanies",
                column: "CompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_CountryName",
                table: "GlobalCompanies",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_DataCenter",
                table: "GlobalCompanies",
                column: "DataCenter");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_EmailAddress",
                table: "GlobalCompanies",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_LastActivityDate",
                table: "GlobalCompanies",
                column: "LastActivityDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_NextActivityDate",
                table: "GlobalCompanies",
                column: "NextActivityDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_OwnerGlobalUserId",
                table: "GlobalCompanies",
                column: "GlobalCompanyOwnerGlobalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_SalesTeam",
                table: "GlobalCompanies",
                column: "SalesTeam");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCompanies_SubscriberId",
                table: "GlobalCompanies",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalCompanies_10CA500D7223E2EC91B667A7C5E858F6",
                table: "GlobalCompanies",
                columns: new[] { "Active", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalCompanies_290F1424F11953EABF953389262563A0",
                table: "GlobalCompanies",
                columns: new[] { "Active", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalCompanies_48F29F86A3977830A905D27754C3583B",
                table: "GlobalCompanies",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalCompanies_901C83189E4E682D3B6CCD676ACEDFF1",
                table: "GlobalCompanies",
                columns: new[] { "Active", "CompanyOwnerUserIdGlobal" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalCompanies_C1885F9E5C5DFACE2377DD372D5C2208",
                table: "GlobalCompanies",
                columns: new[] { "SubscriberId", "Active", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_Company_Id_Global",
                table: "GlobalDeals",
                column: "CompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_CompanyIdGlobal",
                table: "GlobalDeals",
                column: "CompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_ContractEndDate",
                table: "GlobalDeals",
                column: "ContractEndDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_ContractStartDate",
                table: "GlobalDeals",
                column: "ContractStartDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_CountryName",
                table: "GlobalDeals",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DataCenter",
                table: "GlobalDeals",
                column: "DataCenter");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DateLost",
                table: "GlobalDeals",
                column: "DateLost");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DealOwnerIdGlobal",
                table: "GlobalDeals",
                column: "DealOwnerIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DealOwnerName",
                table: "GlobalDeals",
                column: "DealOwnerName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DealOwnerUserId",
                table: "GlobalDeals",
                column: "DealOwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DecisionDate",
                table: "GlobalDeals",
                column: "DecisionDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DistrictCode",
                table: "GlobalDeals",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_DistrictName",
                table: "GlobalDeals",
                column: "DistrictName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_EstimatedStartDate",
                table: "GlobalDeals",
                column: "EstimatedStartDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_Industry",
                table: "GlobalDeals",
                column: "Industry");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_LastActivityDate",
                table: "GlobalDeals",
                column: "LastActivityDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_LocationCode",
                table: "GlobalDeals",
                column: "LocationCode");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_LocationName",
                table: "GlobalDeals",
                column: "LocationName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_NextActivityDate",
                table: "GlobalDeals",
                column: "NextActivityDate");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_RegionCode",
                table: "GlobalDeals",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_RegionName",
                table: "GlobalDeals",
                column: "RegionName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_SalesStageName",
                table: "GlobalDeals",
                column: "SalesStageName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalDeals_SubscriberId",
                table: "GlobalDeals",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalDeals_657E462AACFA95127F6F30B78A435768",
                table: "GlobalDeals",
                columns: new[] { "Deleted", "SalesStageName", "CompanyIdGlobal" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalDeals_6C599615C8130DBA7C8610E563FBABC0",
                table: "GlobalDeals",
                columns: new[] { "DealId", "SubscriberId" });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalLocations_CountryCode",
                table: "GlobalLocations",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalLocations_CountryName",
                table: "GlobalLocations",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalLocations_LocationCode",
                table: "GlobalLocations",
                column: "LocationCode");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalLocations_LocationName",
                table: "GlobalLocations",
                column: "LocationName");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalUserActivity",
                table: "GlobalUserActivity",
                columns: new[] { "ContactId", "ContactSubscriberId" });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalUserActivity_GlobalCompanyId",
                table: "GlobalUserActivity",
                column: "GlobalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalUserActivity_GlobalDealId",
                table: "GlobalUserActivity",
                column: "GlobalDealId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalUserActivity_E3803A753DEEC594BA26CCC96E2788F0",
                table: "GlobalUserActivity",
                columns: new[] { "SubscriberId", "UserActivityId" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_GlobalUsers_D0465F9776D4D05E984BA01FDBE215EB",
                table: "GlobalUsers",
                columns: new[] { "LoginEnabled", "SubscriberId", "CountryName", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePhrases_LanguagePhrase",
                table: "LanguagePhrases",
                column: "LanguagePhrase");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTranslations_LanguageCode",
                table: "LanguageTranslations",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTranslations_LanguageName",
                table: "LanguageTranslations",
                column: "LanguageName");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTranslations_LanguagePhrase",
                table: "LanguageTranslations",
                column: "LanguagePhrase");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTranslations_Translation",
                table: "LanguageTranslations",
                column: "Translation");

            migrationBuilder.CreateIndex(
                name: "nci_wi_LanguageTranslations_098F508CEAB243DBB7076C569079F80D",
                table: "LanguageTranslations",
                columns: new[] { "LanguageCode", "Verified" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkActivityToDeal_ActivityId",
                table: "LinkActivityToDeal",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkActivityToDeal_95ADA3F32612F23AC634480012EF864A",
                table: "LinkActivityToDeal",
                columns: new[] { "DealId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_LinkCompanyToCompany_LinkedCompanyIdGlobal",
                table: "LinkCompanyToCompany",
                column: "LinkedCompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCompanyToCompany_SubscriberId",
                table: "LinkCompanyToCompany",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCompanyToCompanyCompanyIdGlobal",
                table: "LinkCompanyToCompany",
                column: "CompanyIdGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCountryRegion_CountryCode",
                table: "LinkCountryRegion",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCountryRegion_CountryName",
                table: "LinkCountryRegion",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCountryRegion_RegionName",
                table: "LinkCountryRegion",
                column: "RegionName");

            migrationBuilder.CreateIndex(
                name: "IX_LinkCountryRegion_SubscriberId",
                table: "LinkCountryRegion",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkGlobalCompanyGlobalUser_3385453A2252F86AC242B7E00D5F7325",
                table: "LinkGlobalCompanyGlobalUser",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkGlobalCompanyGlobalUser_4E279FADEDC4F2E729C9FEC27DF370BB",
                table: "LinkGlobalCompanyGlobalUser",
                columns: new[] { "GlobalCompanyId", "GlobalUserId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkGlobalCompanyGlobalUser_C51D1C0979FF3B8D209398E00848236E",
                table: "LinkGlobalCompanyGlobalUser",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkGlobalCompanyGlobalUser_CB1A5B3EE57547D4C99AD3C4397A56A9",
                table: "LinkGlobalCompanyGlobalUser",
                columns: new[] { "GlobalUserId", "GlobalCompanyId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "nci_wi_LinkGlobalDealGlobalUser_41FA358F80584D7D7BE5149D7D47109F",
                table: "LinkGlobalDealGlobalUser",
                columns: new[] { "GlobalDealId", "GlobalUserId", "Deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberTransferStep_SubscriberTransferId",
                table: "SubscriberTransferStep",
                column: "SubscriberTransferId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberTransferStepError_SubscriberTransferStepId",
                table: "SubscriberTransferStepError",
                column: "SubscriberTransferStepId");

            migrationBuilder.CreateIndex(
                name: "IX_UnlocoCodes_CountryName",
                table: "UnlocoCodes",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_UnlocoCodes_LocationName",
                table: "UnlocoCodes",
                column: "LocationName");

            migrationBuilder.CreateIndex(
                name: "IX_UnlocoCodes_PortName",
                table: "UnlocoCodes",
                column: "PortName");

            migrationBuilder.CreateIndex(
                name: "IX_UnlocoCodes_UnlocoCode",
                table: "UnlocoCodes",
                column: "UnlocoCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_SubscriberId",
                table: "UserRoles",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserRole",
                table: "UserRoles",
                column: "UserRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ActivititesMembers");

            migrationBuilder.DropTable(
                name: "AdminUser");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "AsyncReportRequest");

            migrationBuilder.DropTable(
                name: "AsyncThreads");

            migrationBuilder.DropTable(
                name: "BillingContacts");

            migrationBuilder.DropTable(
                name: "BillingEntities");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "CompanyCompetitor");

            migrationBuilder.DropTable(
                name: "CompanyContactsImportRequest");

            migrationBuilder.DropTable(
                name: "CompanyImportRequest");

            migrationBuilder.DropTable(
                name: "CompanyLanes");

            migrationBuilder.DropTable(
                name: "CompanyLinkTypes");

            migrationBuilder.DropTable(
                name: "CompanyWarehouses");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "CurrencyExchangeRates");

            migrationBuilder.DropTable(
                name: "DealExchangeRateUpdateServiceLog");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "ExchangeRatesLog");

            migrationBuilder.DropTable(
                name: "ExchangeServerTimezones");

            migrationBuilder.DropTable(
                name: "ExchangeSyncErrorLog");

            migrationBuilder.DropTable(
                name: "ExchangeSyncLog");

            migrationBuilder.DropTable(
                name: "ForgotPasswordRequests");

            migrationBuilder.DropTable(
                name: "FreeTrialRequests");

            migrationBuilder.DropTable(
                name: "GlobalCompanies");

            migrationBuilder.DropTable(
                name: "GlobalCompanyAccessRequest");

            migrationBuilder.DropTable(
                name: "GlobalContacts");

            migrationBuilder.DropTable(
                name: "GlobalDeals");

            migrationBuilder.DropTable(
                name: "GlobalLanes");

            migrationBuilder.DropTable(
                name: "GlobalLocations");

            migrationBuilder.DropTable(
                name: "GlobalQuotes");

            migrationBuilder.DropTable(
                name: "GlobalUserActivationsDeactivations");

            migrationBuilder.DropTable(
                name: "GlobalUserActivity");

            migrationBuilder.DropTable(
                name: "GlobalUsers");

            migrationBuilder.DropTable(
                name: "GoogleSyncErrorLog");

            migrationBuilder.DropTable(
                name: "GoogleSyncLog");

            migrationBuilder.DropTable(
                name: "Incoterms");

            migrationBuilder.DropTable(
                name: "InvoiceActiveUsers");

            migrationBuilder.DropTable(
                name: "InvoiceContacts");

            migrationBuilder.DropTable(
                name: "InvoiceEmail");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "InvoiceSent");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropTable(
                name: "InvoiceStatusHistory");

            migrationBuilder.DropTable(
                name: "LanguagePhrases");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "LanguageTranslations");

            migrationBuilder.DropTable(
                name: "LinkActivityToDeal");

            migrationBuilder.DropTable(
                name: "LinkCompanyToCompany");

            migrationBuilder.DropTable(
                name: "LinkCountryRegion");

            migrationBuilder.DropTable(
                name: "LinkGlobalCompanyGlobalUser");

            migrationBuilder.DropTable(
                name: "LinkGlobalContactToCompany");

            migrationBuilder.DropTable(
                name: "LinkGlobalContactToDeal");

            migrationBuilder.DropTable(
                name: "LinkGlobalDealGlobalUser");

            migrationBuilder.DropTable(
                name: "LinkGlobalSuscriberToSubscriber");

            migrationBuilder.DropTable(
                name: "LinkGlobalUserToGlobalContact");

            migrationBuilder.DropTable(
                name: "LinkGlobalUserToGlobalManager");

            migrationBuilder.DropTable(
                name: "LinkGlobalUserToManagingCountry");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OutlookCategoryColors");

            migrationBuilder.DropTable(
                name: "ReassignUserRequest");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "ReportFilters");

            migrationBuilder.DropTable(
                name: "SalesTeamRoles");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "SubscriberTransferStepError");

            migrationBuilder.DropTable(
                name: "SwitchUserRequest");

            migrationBuilder.DropTable(
                name: "TableStatus");

            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "TimeZones");

            migrationBuilder.DropTable(
                name: "TimeZonesDaylightSavings");

            migrationBuilder.DropTable(
                name: "UnlocoCodes");

            migrationBuilder.DropTable(
                name: "UserEmailLinks");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WebAppErrors");

            migrationBuilder.DropTable(
                name: "WorkflowAccountEvents");

            migrationBuilder.DropTable(
                name: "WorkflowAccounts");

            migrationBuilder.DropTable(
                name: "SubscriberTransferStep");

            migrationBuilder.DropTable(
                name: "SubscriberTransfer");
        }
    }
}
