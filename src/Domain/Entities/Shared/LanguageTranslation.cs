using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LanguageTranslation
{
    public int LanguageTranslationId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageName { get; set; }

    public string? LanguagePhrase { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Translation { get; set; }

    public int? UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public bool Verified { get; set; }

    public int? VerifiedUserId { get; set; }

    public string? VerifiedUserName { get; set; }
}
