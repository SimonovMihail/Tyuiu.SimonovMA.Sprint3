using System;
using Tyuiu.SimonovMA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void gicha()
        {
            DataService ds = new DataService();
            int start = -5;
            int finish = 5;
            double result = ds.Calculate(-5, 5);
            Assert.AreEqual(-35.317, result);
        }
    }
}