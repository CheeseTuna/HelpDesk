using Helpdesk.Data;
using HelpDesk.Models;
using HelpDesk.Models.Entities;
using HelpDesk.Models.ViewModels;
using HelpDesk.Models.ViewModels.Tickets;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Tickets()
        {
            var tickets = _context.Tickets
            .Select(t => new TicketsViewModel
            {
                TicketId = t.TicketId,
                Title = t.Title,
                CategoryId = t.CategoryId,
                PriorityId = t.PriorityId,
                StatusId = t.StatusId,
                Created = t.Created
            })
            .ToList();
            return View(tickets);
        }

        public IActionResult MyTickets()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTicket()
        {
            var viewModel = new CreateTicketViewModel
            {
                Categories = _context.Category.ToList(),
                Priorities = _context.Priority.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTicket(CreateTicketViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _context.Category.ToList();
                model.Priorities = _context.Priority.ToList();


                return View(model);
            }
            // Create a Ticket entity from the submitted values
            var ticket = new Tickets
            {
                Title = model.Title,
                Description = model.Description,
                CategoryId = model.CategoryId,
                PriorityId = model.PriorityId,
                Created = DateTime.Now,
                IsDeleted = false

            };

            // Add Ticket to EF Context
            _context.Tickets.Add(ticket);

            // Save Changes
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(MyTickets));
        }

        [HttpGet]
        public IActionResult GetMyTickets()
        {
            return View();
        }


    }
}