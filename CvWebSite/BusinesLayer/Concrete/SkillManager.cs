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
            _skillDall.Insert(t);
        }

        public void TDelete(Skill t)
        {
           _skillDall.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return _skillDall.GetById(id);  
        }

        public List<Skill> TGetList()
        {
           return _skillDall.GetList();
        }

        public List<Skill> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
           _skillDall.Update(t);
        }
    }
}
