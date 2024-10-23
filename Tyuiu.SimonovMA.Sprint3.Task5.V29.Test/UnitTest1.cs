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
            double result = ds.GetSumSumSeries(2, 1, 3, 1, 10);
            Assert.AreEqual(7.274, result);
        }
    }
}