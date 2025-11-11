using System;
using System.Collections.Generic;

namespace Afanasev.Models;

public partial class Production
{
    public int ProductionId { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public DateOnly ProductionsDate { get; set; }
}
