using projekt_indywidualny_etap_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_indywidualny_etap_3.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ViewResult Index(string searchString, string eventCategoryFilter, string locationFilter, DateTime? dateFilter)
        {
            using (var context = ApplicationDbContext.Create())
            {
                ViewBag.EventCategoriesList = context.Categories.ToList();
                ViewBag.LocationsList = context.Events.Select(e => e.Location).Distinct().ToList();

                var @events = context.Events
                                .Include("EventType")
                                .Include("EventCategory")
                                .AsQueryable();

                if (!string.IsNullOrEmpty(searchString))
                    @events = @events.Where(e => e.Title.Contains(searchString));

                if (!string.IsNullOrEmpty(eventCategoryFilter))
                    @events = @events.Where(e => e.EventCategory.Name == eventCategoryFilter);

                if (!string.IsNullOrEmpty(locationFilter))
                    @events = @events.Where(e => e.Location == locationFilter);

                if (dateFilter != null)
                    @events = @events.Where(e => DbFunctions.TruncateTime(e.StartTime) == DbFunctions.TruncateTime(dateFilter));
                    
                return View(@events.ToList());
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
