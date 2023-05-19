using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class ExperinceManager : IExperinceDal
    {
        IExperinceDal _experinceDal;

        public ExperinceManager(IExperinceDal experinceDal)
        {
            _experinceDal = experinceDal;
        }

        public void Delete(Experience t)
        {
           _experinceDal.Delete(t);
        }

        public Experience GetById(int id)
        {
          return  _experinceDal.GetById(id);
        }

        public List<Experience> GetList()
        {
          return _experinceDal.GetList();
        }

        public void Insert(Experience t)
        {
           _experinceDal.Insert(t);
        }

        public void Update(Experience t)
        {
           _experinceDal?.Update(t);
        }
    }
}
