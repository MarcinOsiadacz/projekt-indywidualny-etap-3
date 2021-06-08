using projekt_indywidualny_etap_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_indywidualny_etap_3.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            using (var context = ApplicationDbContext.Create())
            {
                var @events = context.Events
                                .Include("EventType")
                                .Include("EventCategory")
                                .ToList();

                return View(@events);
            }
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            using (var context = ApplicationDbContext.Create())
            {
                var @event = context.Events
                                .Include("EventType")
                                .Include("EventCategory")
                                .Where(e => e.Id == id)
                                .FirstOrDefault();

                return View(@event);
            }
        }
    }
}
