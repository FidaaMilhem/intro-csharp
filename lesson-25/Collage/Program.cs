using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collage
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public List<RegCourse> Courses { get; set; }
    }

    public class RegCourse
    {
        public int Id { get; set; }
        public string Student { get; set; }
        public string Course { get; set; }
        public string Status { get; set; }
        public int Grade { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        []
    }

    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        public List<Course> Teaches { get; set; }

    }
    public class CollageContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<RegCourse> RegCourseurses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public CollageContext()
            : base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                        .Property(c => c.Name)
                        .IsRequired()
                        .HasMaxLength(255);  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
