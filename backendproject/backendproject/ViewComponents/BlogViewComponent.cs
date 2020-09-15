using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public BlogViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count=9)
        {
            IEnumerable<Blog> model = _db.Blogs.Take(count);
            return View(await Task.FromResult(model));
        }
    }
}
