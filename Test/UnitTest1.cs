using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(OOP_lab_2_9_4.Program.IndexOfMaxAbs(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 9);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(OOP_lab_2_9_4.Program.Multiplication(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 3628800);
        }
    }
}
