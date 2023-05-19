using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        //Web sitesinin girişindeki "hakkında" bölümünün bir kimliği veya numarasıdır. Bu özellik, hakkında bölümünü benzersiz bir şekilde tanımlamak için kullanılabilir.

        public int AboutId { get; set; }

        //Bu özellik, hakkında bölümünün başlığını temsil eder. Başlık, hakkında bölümünün üst kısmında yer alır ve genellikle kısa ve öz bir ifade içerir. Boş bırakılabilir, yani başlık olmayabilir.
        public string? Title { get; set; }

        //Bu özellik, hakkında bölümünün içeriğini temsil eder. İçerik, hakkında bölümünde daha geniş bir açıklama veya metin içerebilir. Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Description { get; set; }
        //Bu özellik, hakkında bölümünün yaş içeriğini temsil eder,Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Age { get; set; }
        //Bu özellik, hakkında bölümünün mail içeriğini temsil eder,Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Mail { get; set; }
        //Bu özellik, hakkında bölümünün telefon numarası içeriğini temsil eder,Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Phone { get; set; }
        //Bu özellik, hakkında bölümünün adres içeriğini temsil eder,Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Adress { get; set; }

        //Bu özellik, hakkında bölümünün resim içeriğini temsil eder.
        public string? ImageUrl { get; set; }
    }
}
