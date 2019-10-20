using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewAssignment;


namespace UnitTestBook
{
    [TestClass]
    public class UnitTest1
    {
        Book book = new Book("sdada", "dsadda", 32 , "dsada");
 

        [TestMethod]
        public void TitleName()
        {
            // book.title = "dsad";;
            book.title = "popo";
            Assert.AreEqual(book.title, "popo");
        }

        [TestMethod]
        public void TitleException()
        {

            //  var exception = Assert.ThrowsException<System.ArgumentException>, "sdada";
            book.title = "sdd";


            //  Assert.IsTrue(book.title, "sdada", ArgumentOutOfRangeException);

        }


    }
}
