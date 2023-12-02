using System;
using System.Collections.Generic;

namespace StockShop.Models;

/// <summary>
/// персональная информация о юзерах
/// </summary>
public partial class PersonalDatum
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string Patronomic { get; set; } = null!;

    public DateOnly? DateBirth { get; set; }

    public string? SeriesPassport { get; set; }

    public string? NumberPassport { get; set; }

    public int? UserProfileId { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual UserProfile? UserProfile { get; set; }
}
