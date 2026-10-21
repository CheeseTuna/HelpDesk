namespace HelpDesk.Models.Entities;

public class Priority
{
    public int PriorityId { get; set; }
    public int? PriorityLevel { get; set; }
    public string? PriorityLabel { get; set; }
    public bool? IsDeleted { get; set; }
}
