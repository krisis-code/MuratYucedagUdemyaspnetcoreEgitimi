﻿using EntityLayer.Concrete;

namespace BusinesLayer.Abstract
{
    public interface IUserMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessageWithUserService();
    }
}