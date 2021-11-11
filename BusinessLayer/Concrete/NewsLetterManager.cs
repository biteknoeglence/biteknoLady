using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsLetterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }
        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(NewsLetter t)
        {
            _newsletterDal.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
