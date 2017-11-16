using Microsoft.EntityFrameworkCore;
using VSTS.School.Core.Models;

namespace VSTS.School.EntityFramework
{
    public class SchoolDbcontext : DbContext
    {
        public SchoolDbcontext(DbContextOptions<SchoolDbcontext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course").Property(a => a.CourseId).ValueGeneratedNever();
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment").HasOne(a => a.Student).WithMany(a => a.Enrollments)
                .HasForeignKey(a => a.StudentId);
            modelBuilder.Entity<Enrollment>().HasOne(a => a.Course).WithMany(a => a.Enrollments);
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}