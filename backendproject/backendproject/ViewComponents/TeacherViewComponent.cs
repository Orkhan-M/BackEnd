using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class TeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public TeacherViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Teacher> model = _db.Teachers.ToList();
            return View(await Task.FromResult(model));
        }
    }
}
