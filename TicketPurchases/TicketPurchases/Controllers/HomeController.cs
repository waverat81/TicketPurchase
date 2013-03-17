using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketPurchases.Models;

namespace TicketPurchases.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult BuyTickets()
        {
            return View();
        }
        [HttpPost]
        public ViewResult BuyTickets(BuyTickets buyTickets)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to organzier
                return View("Thanks", buyTickets);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}
