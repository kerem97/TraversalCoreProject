using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context c = new Context();
        public void ChangeToFalse(int id)
        {

            var values = c.Guides.Find(id);
            values.Status = false;
            c.SaveChanges();
        }

        public void ChangeToTrue(int id)
        {

            var values = c.Guides.Find(id);
            values.Status = true;
            c.SaveChanges();
        }
    }
}
