using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class ExperinceManager : IExperinceService
    {
        IExperinceDal _experinceDal;

        public ExperinceManager(IExperinceDal experinceDal)
        {
            _experinceDal = experinceDal;
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
           return _experinceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
