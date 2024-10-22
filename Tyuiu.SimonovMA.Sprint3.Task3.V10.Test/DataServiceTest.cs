using System;
using Tyuiu.SimonovMA.Sprint3.Task3.V10.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string start = "gdfppf vfppt p";
            char forbidden = 'p';
            string finish = ds.DeleteCharInString(start, forbidden);
            Assert.AreEqual("gdff vft ", finish);
        }
    }
}