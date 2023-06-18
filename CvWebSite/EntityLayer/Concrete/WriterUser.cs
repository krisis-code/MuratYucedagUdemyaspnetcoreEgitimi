using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    
    public class WriterUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surename { get; set; }
        public string ImageUrl { get; set; }


       
    }
}
