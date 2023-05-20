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

    public class SkillManager : ISkillService
    {
        ISkillDall _skillDall;

        public SkillManager(ISkillDall skillDall)
        {
            _skillDall = skillDall;
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
           return _skillDall.GetList();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
