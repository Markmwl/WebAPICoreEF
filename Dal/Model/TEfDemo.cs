using System;
using System.Collections.Generic;

namespace Dal.Model;

public partial class TEfDemo
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public decimal Age { get; set; }

    public DateTime Time { get; set; }

    public string? Text { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Dept { get; set; }

    public string? Hobbly { get; set; }
}
