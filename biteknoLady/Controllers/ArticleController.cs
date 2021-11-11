using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        ArticleManager artm = new ArticleManager(new EfArticleRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = artm.GetArticleListWithCategory();
            return View(values);
        }

        public IActionResult Coltwo()
        {
            var values = artm.GetList();
            return View(values);
        }

        public IActionResult Colthree()
        {
            var values = artm.GetList();
            return View(values);
        }

        public IActionResult ArticleReadAll(int id)
        {
            ViewBag.i = id;
            var values = artm.GetArticleByID(id);
            return View(values);
        }

        public IActionResult ArticleListByWriter(int id)
        {
            var values = artm.GetListWithCategoryByWriterID(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult ArticleAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }

        [HttpPost]
        public IActionResult ArticleAdd(Article a)
        {
            ArticleValidator av = new ArticleValidator();
            ValidationResult results = av.Validate(a);
            if (results.IsValid)
            {
                a.ArticleStatus = true;
                a.ArticleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                a.WriterID = 1;
                artm.TAdd(a);
                return RedirectToAction("ArticleListByWriter", "Article");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteArticle(int id)
        {
            var articlevalues = artm.GetById(id);
            artm.TDelete(articlevalues);
            return RedirectToAction("ArticleListByWriter");
        }

        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            var articlevalue = artm.GetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(articlevalue);
        }

        [HttpPost]
        public IActionResult EditArticle(Article a)
        {
            a.WriterID = 1;
            a.ArticleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            a.ArticleStatus = true;
            artm.TUpdate(a);
            return RedirectToAction("ArticleListByWriter");
        }
    }
}
