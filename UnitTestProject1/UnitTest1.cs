using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 7, 5, 3, 0, -5, 9, 10 };

            Assert.AreEqual(4, ConsoleApp1.Program.FindMinimal(a));
            Assert.AreEqual(105, ConsoleApp1.Program.CompositionBeforeNull(a));
        }
    }
}
