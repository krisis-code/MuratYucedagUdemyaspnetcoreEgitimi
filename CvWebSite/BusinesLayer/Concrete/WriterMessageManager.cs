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

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _WriterMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _WriterMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
           _WriterMessageDal.Insert(t);

        }

        public void TDelete(WriterMessage t)
        {
            _WriterMessageDal.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
           return _WriterMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList(string p)
        {
            return _WriterMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
       
    }
}
