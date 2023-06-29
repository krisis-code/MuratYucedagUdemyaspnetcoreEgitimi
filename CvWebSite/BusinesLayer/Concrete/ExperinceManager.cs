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
            _experinceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
           _experinceDal.Delete(t);
        }

        public Experience TGetById(int id)
        {
           return _experinceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
           return _experinceDal.GetList();
        }

        public List<Experience> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
           _experinceDal.Update(t);
        }
    }
}
