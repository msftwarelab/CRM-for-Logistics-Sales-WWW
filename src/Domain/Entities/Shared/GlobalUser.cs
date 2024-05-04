using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalUser
{
    public int GlobalUserId { get; set; }

    public int SubscriberId { get; set; }

    public string? Address { get; set; }

    public bool AdminUser { get; set; }

    public bool AllowSubscriberCommission { get; set; }

    public string? BillingCode { get; set; }

    public int BillingEntityId { get; set; }

    public string? BrowserName { get; set; }

    public string? BrowserVersion { get; set; }

    public string? City { get; set; }

    public string? CountryCode { get; set; }

    public string CountryName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string CurrencySymbol { get; set; } = null!;

    public string? DataCenter { get; set; }

    public string DateFormat { get; set; } = null!;

    public string DateFormatReports { get; set; } = null!;

    public bool Deleted { get; set; }

    public int DeletedUserId { get; set; }

    public int DeletedGlobalUserId { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? Department { get; set; }

    public string DisplayLanguage { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string? EmailDigest { get; set; }

    public string FullName { get; set; } = null!;

    public string? IpAddress { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? LanguageName { get; set; }

    public string? LanguagesSpoken { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? LocationCode { get; set; }

    public int LocationId { get; set; }

    public string? LocationName { get; set; }

    public bool LoginEnabled { get; set; }

    public string? MobilePhone { get; set; }

    public string? Phone { get; set; }

    public string? PhoneExtension { get; set; }

    public string? Phone2 { get; set; }

    public string? Preferences { get; set; }

    public string? ProfilePicture { get; set; }

    public string? PostalCode { get; set; }

    public bool Quoting { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public string? ScreenResolution { get; set; }

    public string? SignatureImage { get; set; }

    public string? SignatureText { get; set; }

    public string? StateProvince { get; set; }

    public string? SubscriberName { get; set; }

    public string TimeZone { get; set; } = null!;

    public string? TimeZoneCityNames { get; set; }

    public string? TimeZoneExchange { get; set; }

    public string? TimeZoneOffset { get; set; }

    public string? Title { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public DateTime? UserActivationDate { get; set; }

    public DateTime? UserDeactivationDate { get; set; }

    public string? UserRoles { get; set; }

    public int UserId { get; set; }

    public string? UserGuid { get; set; }

    public int ConversionUserIdGlobal { get; set; }

    public int DefaultReminderMinutes { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public bool EmailSummaryDaily { get; set; }

    public DateTime? EmailSummaryLastSent { get; set; }

    public bool EmailActivityReminders { get; set; }

    public int EmailActivityReminderMinutes { get; set; }

    public string? Fax { get; set; }

    public string? FirstName { get; set; }

    public string? GoogleCalendarEmail { get; set; }

    public string? SyncPasswordHashed { get; set; }

    public string? GoogleRefreshToken { get; set; }

    public string? GoogleSyncToken { get; set; }

    public string? LastName { get; set; }

    public int LoginFailures { get; set; }

    public string? Password { get; set; }

    public string? PasswordHashed { get; set; }

    public bool SyncOnlyCrmCategoryItems { get; set; }

    public DateTime? SyncAppointmentsLastDateTime { get; set; }

    public DateTime? SyncContactsLastDateTime { get; set; }

    public string? SyncEmail { get; set; }

    public string? SyncPassword { get; set; }

    public string? SyncState { get; set; }

    public DateTime? SyncTasksLastDateTime { get; set; }

    public string? SyncType { get; set; }

    public bool SyncIsLegacy { get; set; }

    public string? SyncUserName { get; set; }

    public string? Version { get; set; }

    public bool CustomerProfileActive { get; set; }

    public bool VisitReportEnabled { get; set; }

    public bool WorkflowEnabled { get; set; }

    public string? WorkflowSettings { get; set; }

    public string? AppCenter { get; set; }

    public bool EnableO365sync { get; set; }
}
