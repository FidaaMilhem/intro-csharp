using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public record Lend(Book Title, List<Person> Id, Book Copies) { }
}
