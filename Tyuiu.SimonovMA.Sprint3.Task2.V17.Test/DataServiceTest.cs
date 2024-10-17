using System;
using Tyuiu.SimonovMA.Sprint3.Task2.V17.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            Assert.AreEqual(4.399, ds.GetSumSeries(1, 10));
        }
    }
}