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
    public class AnnouncementsManager : IAnnouncementsService
    {


        IannouncementsDal _ıannouncementsDal;

        public AnnouncementsManager(IannouncementsDal ıannouncementsDal)
        {
            _ıannouncementsDal = ıannouncementsDal;
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetById(int id)
        {
            return _ıannouncementsDal.GetById(id);
        }

        public List<Announcement> TGetList()
        {
           return _ıannouncementsDal.GetList();
        }

        public List<Announcement> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
