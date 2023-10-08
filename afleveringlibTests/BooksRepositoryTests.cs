using Microsoft.VisualStudio.TestTools.UnitTesting;
using afleveringlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afleveringlib.Tests
{
    [TestClass()]
    public class BooksRepositoryTests
    {
        private readonly Book book1 = new Book { Id = 10, Title = "khalid", Price = 10 };
        private readonly List<Book> _book;
        [TestMethod()]
        public void BooksRepositoryTest()
        {
            var repo = new BooksRepository();
            Assert.AreEqual(5,repo.GetallBook().Count());
            
        }

        [TestMethod()]
        [DataRow("khalid", 100)]
        public void AddTest(string title,int price)
        {
            //
            var repo = new BooksRepository();
            var bookadd = new Book { Title= title, Price = price };
            //
            var addabook = repo.Add(bookadd);
            //
            Assert.IsNotNull(addabook);
            Assert.AreEqual(title, addabook.Title);
            Assert.AreEqual(price, addabook.Price);

            var bookinlist = repo.GetallBook().FirstOrDefault(k => k.Id == addabook.Id);
            Assert.IsNotNull(bookinlist);
            Assert.AreEqual(bookadd.Title, bookinlist.Title);
            Assert.AreEqual(bookadd.Price, bookinlist.Price);


        }

        [TestMethod()]
        [DataRow(9,"NOPE",99)]
        public void GetbyidTest(int id,string title,int price)
        {
            var repo = new BooksRepository();
            var bookget = new Book {Id = id, Title= title, Price = price };
            //
            var add = repo.Add(bookget);
            var re = repo.Getbyid(add.Id);
            //
            Assert.IsNotNull(add);
            Assert.AreEqual(add.Id,re.Id);
            Assert.AreEqual(add.Title,re.Title);
            Assert.AreEqual(add.Price,bookget.Price);

            
        }

    }
}