using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.HelloWorld();
            Assert.AreEqual("HelloWorld", result);
        }
    }
}
