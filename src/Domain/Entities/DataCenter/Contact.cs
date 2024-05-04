﻿namespace FirstFreightAPI.Entities.DataCenter;

public partial class Contact
{
    public int ContactId { get; set; }

    public int SubscriberId { get; set; }

    public int BirthdayDay { get; set; }

    public int BirthdayMonth { get; set; }

    public string? BusinessAddress { get; set; }

    public string? BusinessCity { get; set; }

    public string? BusinessCountry { get; set; }

    public string? BusinessCountryCode { get; set; }

    public string? BusinessPhone { get; set; }

    public string? BusinessPhone2 { get; set; }

    public string? BusinessStateProvince { get; set; }

    public string? BusinessPostalCode { get; set; }

    public string? CampaignName { get; set; }

    public string? ChildrenNames { get; set; }

    public string? Comments { get; set; }

    public int CompanyId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public string? CompanyName { get; set; }

    public string ContactName { get; set; } = null!;

    public int ContactOwnerUserId { get; set; }

    public string? ContactSource { get; set; }

    public string? ContactType { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string? CustomerType { get; set; }

    public string? DecisionRole { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Email { get; set; }

    public string? ExchangeContactId { get; set; }

    public DateTime? ExchangeSyncLastModified { get; set; }

    public string? Fax { get; set; }

    public string? FirstName { get; set; }

    public string? GoogleContactId { get; set; }

    public DateTime? GoogleSyncLastModified { get; set; }

    public string? Hobbies { get; set; }

    public string? HomeAddress { get; set; }

    public string? HomeCity { get; set; }

    public string? HomeCountry { get; set; }

    public string? HomePhone { get; set; }

    public string? HomeStateProvince { get; set; }

    public string? HomePostalCode { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public string? LastName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? MiddleName { get; set; }

    public string? MobilePhone { get; set; }

    public DateTime? NextActivityDate { get; set; }

    public string? OriginSystem { get; set; }

    public bool PrivateContact { get; set; }

    public string? RelatedContacts { get; set; }

    public string? SalesTeam { get; set; }

    public string? Salutation { get; set; }

    public string? Source { get; set; }

    public string? SpouseName { get; set; }

    public string? SyncType { get; set; }

    public string? Tags { get; set; }

    public string? Title { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public string? Website { get; set; }

    public int? ConversionContactId { get; set; }

    public bool ReceiveEmail { get; set; }

    public bool Married { get; set; }

    public bool HasChildern { get; set; }

    public bool OkToCall { get; set; }

    public bool HolidayCards { get; set; }

    public bool FormerEmployee { get; set; }

    public string? PreviousEmployees { get; set; }

    public string? ConversionContactDataCenter { get; set; }
}
