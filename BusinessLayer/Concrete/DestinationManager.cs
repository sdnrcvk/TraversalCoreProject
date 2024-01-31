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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            this._destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Add(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public List<Destination> TGetAll()
        {
            return _destinationDal.GetAll();
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
