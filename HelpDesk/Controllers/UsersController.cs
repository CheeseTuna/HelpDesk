namespace HelpDesk.Controllers;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    public IActionResult Users()
    {
        return View();
    }
}
