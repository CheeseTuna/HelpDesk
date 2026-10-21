namespace HelpDesk.Models.Entities;

public class Status
{
    public int StatusId { get; set; }
    public string? StatusLabel { get; set; }
    public bool? IsDeleted { get; set; }
}
