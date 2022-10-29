using System.Data.Entity;

namespace DataSchool
{
    internal class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string FamilyName { get; set; }
            public string Email { get; set; }
        }

        public class SDbContext : System.Data.Entity.DbContext
        {
            public  DbSet<Student> Students { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}