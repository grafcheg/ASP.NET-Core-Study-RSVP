using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Study___RSVP.Models;

namespace ASP.NET_Core_Study___RSVP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public ViewResult RsvpForm()
    {
        return View();
    }
}