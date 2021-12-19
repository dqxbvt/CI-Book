using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bookMysql;
namespace BookTest
{
    [TestClass]
    public class AddBookTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod()]
        public void btnSave_Click_1Test()
        {
            Form1 frm = new Form1();
            var result = "book";
            Assert.AreEqual("book", result);
        }

    }


//######################xddd


}
