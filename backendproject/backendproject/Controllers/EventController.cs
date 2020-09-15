using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace backendproject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> model = _db.Events.Skip(8).Take(8).ToList();
            return View(model);
        }
    }
}
