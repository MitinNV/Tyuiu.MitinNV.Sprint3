using Tyuiu.MitinNV.Sprint3.Task1.V2.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 0.968;
            Assert.AreEqual(varForTest, ds.GetSumSeries(1, 15));
        }
    }
}