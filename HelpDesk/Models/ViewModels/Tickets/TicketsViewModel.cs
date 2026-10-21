namespace HelpDesk.Models.ViewModels.Tickets;

public class TicketsViewModel
{
    public int TicketId { get; set; }
    public string? Title { get; set; }
    public int CategoryId { get; set; }
    public int PriorityId { get; set; }
    public int? StatusId { get; set; }
    public DateTime? Created { get; set; }
}
