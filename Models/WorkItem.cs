using System;
using System.Collections.Generic;

namespace AdventureWorksAPI;

public partial class WorkItem
{
    public int WorkItemId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Priority { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CreatedAt { get; set; }
}
