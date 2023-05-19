using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class PortfolioManager : IPortfolioDal
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Delete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.GetById(id);
            
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public void Insert(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void Update(Portfolio t)
        {
           _portfolioDal.Update(t);
        }
    }
}
