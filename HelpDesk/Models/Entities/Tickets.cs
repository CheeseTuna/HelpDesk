using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models.Entities;

public class Tickets
{
    [Key]
    public int TicketId { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public int PriorityId { get; set; }
    public int? StatusId { get; set; }
    public Category? Category { get; set; }
    public Priority? Priority { get; set; }
    public Status? Status { get; set; }
    public DateTime? Created { get; set; }
    public string? Assignee { get; set; }
    public bool? IsDeleted { get; set; }
}
