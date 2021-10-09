using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IArticleService
    {
        void ArticleAdd(Article article);
        void ArticleDelete(Article article);
        void ArticleUpdate(Article article);
        List<Article> GetList();
        Article GetById(int id);
        List<Article> GetArticleListWithCategory();

        List<Article> GetArticleListByWriter(int id);

    }
}
