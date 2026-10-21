namespace HelpDesk.Models.Entities;

public class Reports
{
    public int TotalTickets { get; set; }
    public int AverageResolutionTime { get; set; }
    public int SatisfactionRating { get; set; }
    //public List<TicketsByStatus> TicketsByStatus { get; set; }
    //public List<TicketsByCategory> TicketsByCategory { get; set; }
}
