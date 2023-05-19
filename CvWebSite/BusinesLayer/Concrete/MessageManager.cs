using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class MessageManager : IMessageDal
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message GetById(int id)
        {
           return _messageDal.GetById(id);
        }

        public List<Message> GetList()
        {
           return _messageDal.GetList();
        }

        public void Insert(Message t)
        {
           _messageDal.Insert(t);
        }

        public void Update(Message t)
        {
            _messageDal?.Update(t); 
        }
    }
}
