using System;
using Tyuiu.SimonovMA.Sprint3.Task1.V22.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MMMM_MATHEMATICA()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 20;

            Assert.AreEqual(5393.714, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}