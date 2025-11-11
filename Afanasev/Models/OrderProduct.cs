using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class OrderProduct
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public string Unit { get; set; } = null!;
}
