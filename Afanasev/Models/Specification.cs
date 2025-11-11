using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class Specification
{
    public int SpecificationId { get; set; }

    public string SpecificationName { get; set; } = null!;

    public int Count { get; set; }

    public int ManufacturerId { get; set; }
}
