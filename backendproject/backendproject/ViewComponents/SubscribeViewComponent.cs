using backendproject.DAL;
using backendproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.ViewComponents
{
    public class SubscribeViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public SubscribeViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Subscribe model = _db.Subscribes.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
