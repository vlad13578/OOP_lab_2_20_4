using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int result = OOP_lab_2_20_4.Program.maxARR(a);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int result = OOP_lab_2_20_4.Program.dob(a);
            Assert.AreEqual(0, result);
        }
    }

}
