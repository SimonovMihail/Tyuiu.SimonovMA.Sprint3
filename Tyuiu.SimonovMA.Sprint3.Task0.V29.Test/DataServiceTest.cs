using System;
using Tyuiu.SimonovMA.Sprint3.Task0.V29.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int start = 1;
            int stop = 10;

            Assert.AreEqual(0.293, ds.GetSumSeries(0.5, 1, 10));
        }
    }
}