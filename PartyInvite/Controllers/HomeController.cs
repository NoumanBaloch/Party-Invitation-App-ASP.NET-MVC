using PartyInvite.Models;
using System;
using System.Web.Mvc;
namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greating = hour < 12 ? "Good Morning" : "Good Evening";
            return View();
        }
        [HttpGet]
        public ActionResult RSVPForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

    }
}