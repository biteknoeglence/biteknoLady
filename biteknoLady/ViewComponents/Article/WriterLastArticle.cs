using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.ViewComponents.Article
{
    public class WriterLastArticle : ViewComponent
    {
        ArticleManager am = new ArticleManager(new EfArticleRepository());

        public IViewComponentResult Invoke()
        {
            var values = am.GetArticleListByWriter(1);
            return View(values);
        }
    }
}
