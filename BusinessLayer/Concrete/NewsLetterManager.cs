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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.Delete(t);
        }

        public NewsLetter TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> TGetList()
        {
            return _newsLetterDal.GetList();
        }

        public void TInsert(NewsLetter t)
        {
            _newsLetterDal.Insert(t);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
