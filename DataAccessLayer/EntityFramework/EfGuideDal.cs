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
        Context context = new Context();
        public void ChangeTheStatusByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = values.Status ? false : true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
