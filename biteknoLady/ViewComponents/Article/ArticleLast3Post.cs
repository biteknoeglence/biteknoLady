using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.ViewComponents.Article
{
    public class ArticleLast3Post : ViewComponent
    {
        ArticleManager artm = new ArticleManager(new EfArticleRepository());

        public IViewComponentResult Invoke()
        {
            var values = artm.GetLast3Article();
            return View(values);
        }
    }
}
