using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afleveringlib
{
    public class BooksRepository:IBooksRepository 
    {
        private List<Book> _books = new List<Book>();
        public BooksRepository()
        {
            _books = new List<Book>();
            _books.Add(new Book() { Id= 1,Title="khalid",Price=10});
            _books.Add(new Book() { Id = 12, Title = "jahebr", Price = 106 });
            _books.Add(new Book() { Id = 13, Title = "djhrbr", Price = 105 });
            _books.Add(new Book() { Id = 14, Title = "jfjr0r", Price = 104 });
            _books.Add(new Book() { Id = 15, Title = "rnqiwe", Price = 102 });

        }
        public IEnumerable<Book>Get(int? filprice = null, int? sortprice = null)
        {
            List<Book> result = new List<Book>(_books);
            if(filprice!= null)
            {
                result = result.Where(a=> a.Price);
            }
        }
        public List<Book> GetallBook()
        {
            return new List<Book>(_books);
        }
        public Book Add(Book book)
        {
            book.validate();
            _books.Add(book);
            return book;
        }
        public Book Getbyid(int id)
        {
            foreach(Book book in _books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
        public Book Deelete(int id)
        {
            Book delete = Getbyid(id);
            if (delete != null)
            {
                _books.Remove(delete);
                return delete;
            }
            return null;
        }
        public Book Update(int id, Book book)
        {
            book.validate();
            foreach(Book abokk in _books)
            {
                if(abokk.Id == id)
                {
                    abokk.Id = book.Id;
                    abokk.Title = book.Title;
                    abokk.Price = book.Price;
                    return abokk;
                }
            }
            return null;
        }
    }
}
