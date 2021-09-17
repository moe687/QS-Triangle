using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNameSpace;
namespace Software_Quality
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangle obj = new Triangle();
            int hypotenuse = obj.hypotenuse(10, 5);

            Assert.AreEqual(20, hypotenuse);
        }
    }
}
