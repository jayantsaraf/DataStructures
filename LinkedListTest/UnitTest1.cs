using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase_Should_Return_Positive_Search_Result_For_30()
        {
            LinkedListImplement list = new LinkedListImplement();
            bool expected = true;
            list.Add(56);
            list.Add(30);
            list.Add(70);
            bool actual = list.SearchValue(30);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase_Should_Return_Positive_When_40_Inserted_After30()
        {
            LinkedListImplement list = new LinkedListImplement();
            bool expected = true;
            list.Add(56);
            list.Add(30);
            list.Add(70);
            bool actual = list.InsertAtSpecific(40, 30);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase_Should_Return_Positive_When_40_Is_Deleted()
        {
            LinkedListImplement list = new LinkedListImplement();
            bool expected = true;
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            bool actual = list.DeleteSpecific(40);
            Assert.AreEqual(expected, actual);
        }

    }
}
