﻿using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinesLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
           _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
         _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
           return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
          return _messageDal.GetList();
        }

        public List<Message> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
