using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.Controllers
{
    public class DashboardController : Controller
    {
        ArticleManager artm = new ArticleManager(new EfArticleRepository());
        Context c = new Context();

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.v1 = c.Articles.Count().ToString();
            ViewBag.v2 = c.Articles.Where(x => x.WriterID == 1).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
