﻿namespace ProjectRothSSA1.Models.Data;

public partial class Brand {
    public int BrandId {
        get; set;
    }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}