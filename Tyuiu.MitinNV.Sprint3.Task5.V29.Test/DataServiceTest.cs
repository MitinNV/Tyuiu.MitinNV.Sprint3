﻿using Tyuiu.MitinNV.Sprint3.Task5.V29.Lib;

namespace Tyuiu.MitinNV.Sprint3.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 7.274;
            Assert.AreEqual(varForTest, ds.GetSumSumSeries(2, 1, 3, 1, 10));
        }
    }
}