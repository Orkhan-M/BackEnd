using backendproject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeLeft> NoticeLefts { get; set; }
        public DbSet<NoticeRight> NoticeRights { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<NoticeVideoLink> NoticeVideoLinks { get; set; }
    }
}
