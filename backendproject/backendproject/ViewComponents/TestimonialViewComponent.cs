using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public TestimonialViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Testimonial model = _db.Testimonials.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
