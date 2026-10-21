using HelpDesk.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Helpdesk.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}