using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductCost { get; set; } = null!;
}
