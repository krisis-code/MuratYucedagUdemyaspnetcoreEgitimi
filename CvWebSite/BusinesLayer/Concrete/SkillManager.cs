using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{

    public class SkillManager : ISkillDall
    {
        ISkillDall _skillDall;

        public SkillManager(ISkillDall skillDall)
        {
            _skillDall = skillDall;
        }

        public void Delete(Skill t)
        {
            _skillDall.Delete(t);
        }

        public Skill GetById(int id)
        {
            return _skillDall.GetById(id);  
        }

        public List<Skill> GetList()
        {
            return _skillDall.GetList();
        }

        public void Insert(Skill t)
        {
           _skillDall.Insert(t);
        }

        public void Update(Skill t)
        {
            _skillDall?.Update(t);  
        }
    }
}
