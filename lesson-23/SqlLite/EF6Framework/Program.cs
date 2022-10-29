using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var db = new ChinookEntities())
            {
                //var q = from a in db.Artists
                //        where a.Name.EndsWith("n")
                //        select a;


                //var led = from a in db.Artists
                //          where a.Name.Contains("Led")
                //          select a;
                //foreach (var art in led)
                //{
                //    Console.WriteLine($"{art.Name}:");
                //    foreach(var album in art.Albums)
                //    {
                //        Console.WriteLine($"\t{album.Title}");
                //        foreach(var track in album.Tracks)
                //        {
                //            Console.WriteLine($"\t\t{track.Name}  [{track.Genre.Name}]");
                //        }
                //    }

                //}

                var acdc = db.Artists
                    .Where(a => a.Name == "AC/DC")
                    .Include(a => a.Albums)
                    .FirstOrDefault();

                Console.WriteLine($"{acdc.Name}");
                foreach (var album in acdc.Albums)
                {
                    Console.WriteLine($"\t{album.Title}");
                }
            }

            Console.ReadKey();
        }
    }
}
