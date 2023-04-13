using System;
using System.Collections.Generic;

namespace Dal.Model;

public partial class Xxluser
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Sex { get; set; }

    public string? Age { get; set; }

    public string? Address { get; set; }

    public string? Phonenumber { get; set; }

    public DateTime? Currentdate { get; set; }
}
