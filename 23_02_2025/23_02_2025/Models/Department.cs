using System;
using System.Collections.Generic;

namespace _23_02_2025.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? NumOfEmployee { get; set; }

    public string? Requirment { get; set; }
}
