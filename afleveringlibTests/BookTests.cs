using Microsoft.VisualStudio.TestTools.UnitTesting;
using afleveringlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace afleveringlib.Tests
{
    [TestClass()]
    public class BookTests
    {
        private Book book1= new Book { Id= 1, Title= "khalid", Price= 100 };
        private Book bookTitle = new Book { Id = 1, Title = "kh", Price = 1199 };
        private Book bookPrice = new Book { Id = 1, Title = "khalid", Price = 1300 };
        private Book booknegativ = new Book { Id = 5, Title = "iloiuj", Price = -1 };
        [TestMethod()]
        public void ToStringTest()
        {
            string str = book1.ToString();
            Assert.AreEqual("{Id=1, Title=khalid, Price=100}", str);
        }

        [TestMethod()]
        public void validationTitleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => bookTitle.validationTitle());
        }

        [TestMethod()]
        public void validationPriceTest()
        {
            Assert.ThrowsException<ArgumentException>(() => bookPrice.validationPrice());
            Assert.ThrowsException<ArgumentException>(() => booknegativ.validationPrice());


        }
        [TestMethod()]
        public void validateTest()
        {
            book1.validate();
        }
    }
}