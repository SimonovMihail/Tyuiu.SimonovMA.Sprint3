using System;
using Tyuiu.SimonovMA.Sprint3.Task6.V5.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void big_method()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(242, result);
        }
    }
}