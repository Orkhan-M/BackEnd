using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendproject.DAL;
using backendproject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace backendproject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM
            {
                About = _db.Abouts.FirstOrDefault(),
                NoticeVideoLink=_db.NoticeVideoLinks.FirstOrDefault()
            };
            return View(aboutVM);
        }
    }
}
