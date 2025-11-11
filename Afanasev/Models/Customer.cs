using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Inn { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool Salesman { get; set; }

    public bool Buyer { get; set; }
}
