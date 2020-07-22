using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFilmMVCV1.Models;
using Microsoft.AspNetCore.Http;

namespace MyFilmMVCV1.ViewComponents
{
    public class WishListViewComponent : ViewComponent
    {
        const string SessionName = "_Name";
        const string SessionAge = "_Age";
        private readonly IHttpContextAccessor _contextAccessor;

        public WishListViewComponent(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public async Task<IViewComponentResult>InvokeAsync()
    {
            ViewBag.Name = _contextAccessor.HttpContext.Session.GetString(SessionName);
            ViewBag.Age = _contextAccessor.HttpContext.Session.GetInt32(SessionAge);
            return View();
    }
    }



}
