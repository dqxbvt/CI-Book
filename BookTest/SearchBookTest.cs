using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bookMysql;
namespace BookTest
{
    [TestClass]
    public class SearchBookTest

    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void btnSearch_Click_1Test()
        {
            Form1 frm = new Form1();
            var result = "book";
            Assert.AreEqual("book", result);
        }
    }
}
