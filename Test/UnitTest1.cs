using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, OOP_lab_2_3_4.Program.CountLess7(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(44, OOP_lab_2_3_4.Program.Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }
    }
}
