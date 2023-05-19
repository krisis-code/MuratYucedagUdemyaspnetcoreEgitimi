using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        //Web sitesinin girişindeki "hakkında" bölümünün bir kimliği veya numarasıdır. Bu özellik, hakkında bölümünü benzersiz bir şekilde tanımlamak için kullanılabilir.
        public int FeatureId { get; set; }

        //Bu özellik, hakkında bölümünün başlığını temsil eder. Başlık, hakkında bölümünün üst kısmında yer alır ve genellikle kısa ve öz bir ifade içerir. Boş bırakılabilir, yani başlık olmayabilir.
        public string? Header { get; set; }

        //  Bu özellik, hakkında bölümünün ismini temsil eder. İsim, genellikle kişi veya kurum adını ifade eder. Örneğin, bir kişisel blog sitesi ise yazarın adını içerebilir. Boş bırakılabilir, yani isim kısmı olmayabilir.
        public string? Name { get; set; }

        //Bu özellik, hakkında bölümünün içeriğini temsil eder. İçerik, hakkında bölümünde daha geniş bir açıklama veya metin içerebilir. Boş bırakılabilir, yani içerik kısmı olmayabilir.
        public string? Title { get; set; }
    }
}
