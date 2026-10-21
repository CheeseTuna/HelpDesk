using HelpDesk.Models.Entities;

namespace HelpDesk.Models.ViewModels.Tickets;

public class CreateTicketViewModel
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public int PriorityId { get; set; }
    public List<Category> Categories { get; set; } = new();
    public List<Priority> Priorities { get; set; } = new();

}
