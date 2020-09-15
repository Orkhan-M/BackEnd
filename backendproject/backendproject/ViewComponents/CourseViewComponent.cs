using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public CourseViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count=3)
        {
            IEnumerable<Course> model = _db.Courses.Skip(3).Take(count);
            return View(await Task.FromResult(model));
        }
    }
}
