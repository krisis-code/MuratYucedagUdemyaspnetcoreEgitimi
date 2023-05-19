using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        //Skill bölümünün kimliği
        public int SkillId { get; set; }

        //Skill bölümünün başlığı
        public string? Title { get; set; }

        //Skill bölümünün değeri
        public string? Value { get; set; }
    }
}
