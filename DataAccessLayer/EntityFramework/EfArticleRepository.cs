using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfArticleRepository : GenericRepository<Article>, IArticleDal
    {
        public List<Article> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Articles.Include(x => x.Category).ToList();
                    }
        }

        public List<Article> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Articles.Include(x => x.Category).Where(x=>x.WriterID == id).ToList();
            }
        }
    }
}
