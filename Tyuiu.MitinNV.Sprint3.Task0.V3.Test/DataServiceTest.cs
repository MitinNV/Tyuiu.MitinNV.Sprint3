using Tyuiu.MitinNV.Sprint3.Task0.V3.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.GetSumSeries(1, 10));
        }
    }
}