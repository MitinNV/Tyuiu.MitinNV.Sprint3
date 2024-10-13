using Tyuiu.MitinNV.Sprint3.Task7.V10.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 1.83;
            Assert.AreEqual(varForTest, ds.GetMassFunction(0, 0)[0]);
        }
    }
}