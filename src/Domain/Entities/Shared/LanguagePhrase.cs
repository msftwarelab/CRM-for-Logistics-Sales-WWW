using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LanguagePhrase
{
    public int LanguagePhraseId { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedByUserId { get; set; }

    public string? DeletedByUserName { get; set; }

    public string LanguagePhrase1 { get; set; } = null!;

    public DateTime? LastUpdate { get; set; }

    public int? UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }
}
