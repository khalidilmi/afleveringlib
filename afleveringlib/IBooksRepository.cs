using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afleveringlib
{
    public interface IBooksRepository
    {
        public IEnumerable<Book> Get(int? filprice = null, int? sortprice =null);
        public List<Book> GetallBook();
        public Book Getbyid(int id);
        public Book Add(Book book);
        public Book Deelete(int id);
        public Book Update(int id, Book book);


    }
}
