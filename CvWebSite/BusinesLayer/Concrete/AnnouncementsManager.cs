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
            throw new NotImplementedException();
        }

        public List<Announcement> TGetList()
        {
           return _ıannouncementsDal.GetList();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
