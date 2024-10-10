using Tyuiu.MitinNV.Sprint3.Task2.V8.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 6.069;
            Assert.AreEqual(varForTest, ds.GetMultiplySeries(1, 10));
        }
    }
}