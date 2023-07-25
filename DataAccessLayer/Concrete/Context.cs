using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        private readonly IConfiguration _configuration;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sqlDbConnectionString = _configuration.GetConnectionString("MsSqlConnection");
            optionsBuilder.UseSqlServer(sqlDbConnectionString);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
