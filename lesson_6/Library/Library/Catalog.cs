using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog
    {
        private Dictionary<string, Book> _catalogIsbn = new();
        private Dictionary<string, Book> _catalogAuthor = new(); // string is the name of the author
        private Dictionary<string, Book> _catalogTitle = new();
        //public int Count { get { return _catalog.Count; } }
        public int Count => _catalogIsbn.Count;

        public void Add(Book book)
        {
            if (TryAdd(book))
            {
                foreach (Person per in book.Authors)
                {
                    _catalogAuthor.Add(per.FirstName, book);
                }
                _catalogTitle.Add(book.Title, book);                
            }
        }

  
        public bool TryAdd(Book book)
        {
            return _catalogIsbn.TryAdd(book.Isbn, book);
        }
        
        
        //public bool TryAdd2(Book book)
        //{
        //    return _catalogAuthor.TryAdd(book.Authors, book);
        //}
        
        
        public bool TryAdd3(Book book)
        {
            return _catalogTitle.TryAdd(book.Title, book);
        }
        
        
        public (bool, Book) FindByIsbn(string isbn)
        {
            
            if (_catalogIsbn.ContainsKey(isbn)) 
            {
                return (true, _catalogIsbn[isbn]);
            }
            else
            {
                return (false, null);
            }
        }

        
        public (bool, Book) FindByAuthor(string author)
        {
            
            if (_catalogAuthor.ContainsKey(author))
            {
                return (true, _catalogAuthor[author]);
            }
            else
            {
                return (false, null);
            }
        }

        //public List<Book> FindByTitle(string title)   // list
        //{
        //    var lst = new List<Book>();
        //    foreach (var item in _catalogIsbn)
        //    {
        //        if (item.Value.Title == title)
        //        {
        //            lst.Add(item.Value);
        //        }
        //    }

        //    return lst;
        //}

        public (bool, Book) FindByTitle(string title) //Dictionary
        {
            if (_catalogTitle.ContainsKey(title))
            {
                return (true, _catalogTitle[title]);
            }
            else
            {
                return (false, null);
            }
        }

        public List<Book> FindByTitleContains(string title)
        {
            var lst = new List<Book>();
            foreach (var item in _catalogIsbn)
            {
                if (item.Value.Title.Contains(title))
                {
                    lst.Add(item.Value);
                }
            }

            return lst;
        }

    }
}
