using Tyuiu.MitinNV.Sprint3.Task4.V2.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 0.104;
            Assert.AreEqual(varForTest, ds.Calculate(-5, 5));
        }
    }
}