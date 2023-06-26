using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser,WriterRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Home
            //optionsBuilder.UseSqlServer("server=KRISIS\\SQLEXPRESS; database = CvWebSiteDb; integrated security = true; TrustServerCertificate=True;");

            //Work
            optionsBuilder.UseSqlServer("server=DESKTOP-9JCBJ7U\\SQLEXPRESS; database = CvWebSiteDb; integrated security = true; TrustServerCertificate=True;");

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserMessage> userMessages { get; set; }
        public DbSet<TodoList> todoLists { get; set; }
        public DbSet<Announcement  > announcements { get; set; }

    }
}
