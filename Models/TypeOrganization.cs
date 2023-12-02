using System;
using System.Collections.Generic;

namespace StockShop.Models;

public partial class TypeOrganization
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
