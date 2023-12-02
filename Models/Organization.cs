using System;
using System.Collections.Generic;

namespace StockShop.Models;

/// <summary>
/// Организация зарегистрированные в по
/// </summary>
public partial class Organization
{
    public int Id { get; set; }

    public string FullNameOrg { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string Ogrn { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public int PersonalDataId { get; set; }

    public virtual PersonalDatum PersonalData { get; set; } = null!;
}
