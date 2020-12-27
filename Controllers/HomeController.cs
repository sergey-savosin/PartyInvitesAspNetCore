using Microsoft.AspNetCore.Mvc;
using PartyInvitesAspNetCore.Models;

namespace PartyInvitesAspNetCore.Controllers
{
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
            // ToDo: store response
            return View();
		}
    }
}
