using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-OK8DPKT; database = TraversalDB;" +
                " integrated security = true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Feature2> Feature2 { get; set; }
        public DbSet<Guide> Guide { get; set; }
        public DbSet<Newsletter> Newsletter { get; set; }
        public DbSet<SubAbout> SubAbout { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
    }
}
