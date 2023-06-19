using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvWebSite.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name =     "Kullanıcı adı")]

        [Required(ErrorMessage = "Lütfen Kullanıcı adınızı Girin")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]

        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]

        public string Password { get; set; }

    }
}
