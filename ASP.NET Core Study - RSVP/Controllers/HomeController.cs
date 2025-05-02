using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Study___RSVP.Models;

namespace ASP.NET_Core_Study___RSVP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }
    
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            // сохраняем ответ гостя на приглашение
            Repository.AddGuestResponse(guestResponse);
        
            return View("Thanks", guestResponse);
        }
        else
        {
            return View();
        }
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }
}