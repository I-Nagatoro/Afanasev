using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int ManufacturerId { get; set; }

    public DateOnly OrderDate { get; set; }

    public decimal SumCost { get; set; }
}
