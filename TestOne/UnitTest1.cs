using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxTesting;

namespace TestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = MaxNumbers.CheckData<int>(10,20,30);
            Assert.AreEqual(30,result);

            float result1 = MaxNumbers.CheckData<float>(10.0f, 20.5f, 30.09f);
            Assert.AreEqual(30.09f, result1);

            string result2 = MaxNumbers.CheckData<string>("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result2);
        }

    }
}
