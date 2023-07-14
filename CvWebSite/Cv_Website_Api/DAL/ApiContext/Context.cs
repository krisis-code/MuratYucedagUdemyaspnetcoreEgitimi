using Cv_Website_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cv_Website_Api.DAL.ApiContext
{
    public class Context : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Home
            //optionsBuilder.UseSqlServer("server=KRISIS\\SQLEXPRESS; database = CvWebSiteDb; integrated security = true; TrustServerCertificate=True;");

            //Work
            optionsBuilder.UseSqlServer("server=DESKTOP-9JCBJ7U\\SQLEXPRESS; database = CvWebSiteApiDb; integrated security = true; TrustServerCertificate=True;");

        }
        public DbSet <Category> Categories { get; set; }
    }
}
