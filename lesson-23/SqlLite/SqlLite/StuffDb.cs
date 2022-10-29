using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite
{
    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(EMail), IsUnique = true)]
    public class Person
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }        
        public string Twiter { get; set; }
        public string Facebook { get; set; }
        public List<Gadget> Gadgets { get; set; }
    }

    public class Gadget
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsElectric { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        [Column("TimesUsed")]
        public int UsgaeCount { get; set; }
    }

    public class StuffDb : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Gadget> Gadgets { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=M:\train\qafza\stuff.db");
        }
    }
}

