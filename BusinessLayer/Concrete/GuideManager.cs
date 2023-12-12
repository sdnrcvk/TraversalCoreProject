using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            _guideDal.Add(t);
        }

        public void TChangeTheStatusByGuide(int id)
        {
            _guideDal.ChangeTheStatusByGuide(id);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public List<Guide> TGetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
