using HelpDesk.Models;
using HelpDesk.Models.ViewModels.Error;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelpDesk.Controllers;

public class HomeController : Controller
{

    public IActionResult Dashboard()
    {
        return View();
    }
    public IActionResult Tickets()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
