using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        //Web sitesinin servisler bölümünün kimliği
        public int ServiceId { get; set; }

        //Bu özellik, Servisler bölümünün içeriğini temsil eder. İçerik, servisler bölümünde daha geniş bir açıklama veya metin içerebilir. Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Title { get; set; }

        //Bu özellik, servisler bölümünün resim içeriğini temsil eder.
        public string? ImageUrl { get; set; }
    }
}
