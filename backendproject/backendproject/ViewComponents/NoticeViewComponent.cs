using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class NoticeViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public NoticeViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<NoticeLeft> model = _db.NoticeLefts.ToList();
            return View(await Task.FromResult(model));
        }
    }
}
