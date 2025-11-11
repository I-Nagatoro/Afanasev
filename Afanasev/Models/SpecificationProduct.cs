using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class SpecificationProduct
{
    public int SpecificationId { get; set; }

    public int ProductId { get; set; }

    public string? Unit { get; set; }

    public decimal Count { get; set; }
}
