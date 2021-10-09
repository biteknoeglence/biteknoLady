using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager am = new ArticleManager(new EfArticleRepository());
        public IActionResult Index()
        {
            var values = am.GetArticleListWithCategory();
            return View(values);
        }

        public IActionResult Coltwo()
        {
            var values = am.GetList();
            return View(values);
        }

        public IActionResult Colthree()
        {
            var values = am.GetList();
            return View(values);
        }

        public IActionResult ArticleReadAll(int id)
        {
            ViewBag.i = id;
            var values = am.GetArticleByID(id);
            return View(values);
        }
    }
}
