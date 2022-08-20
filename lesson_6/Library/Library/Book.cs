using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        public string Title { get; set; }
        public string Authors { get; set; }
        public string ISBN { get; set; }
        public int Copies { get; set; }

    }
    public Book(string _title, string _authors, string _isbn, string _copies)
    {
        Title = _title;
        Authors = _authors;
        ISBN = _isbn;
        Copies = _copies;
    }
    public void listofbook(string _title, string _authors, string _isbn, string _copies)
    {
        
        var list = new List<string>();
        list.Add(_authors);
        list.Add(_isbn);
        list.Add(_copies);

        var d2 = new Dictionary<string, List<string>>();
        d2.Add(_title, list);

    }
    public void  lookfor(Dictionary<string, List<string>>)
    {
        

    }

}
