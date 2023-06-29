using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _WriterMessageDal;

       

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _WriterMessageDal = writerMessageDal;
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

       

        public List<WriterMessage> TGetListByFilter(string p)
        {
            return _WriterMessageDal.GetByFilter(x => x.Receiver == p);
        }

       

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
       
    }
}
