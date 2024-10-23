using System;
using Tyuiu.SimonovMA.Sprint3.Task5.V29.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void giga_test()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(2, 1, 1, 3, 10);
            Assert.AreEqual(44.853, result);
        }
    }
}