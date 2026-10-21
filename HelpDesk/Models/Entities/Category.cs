namespace HelpDesk.Models.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryLabel { get; set; }
    public bool? IsDeleted { get; set; }
}
