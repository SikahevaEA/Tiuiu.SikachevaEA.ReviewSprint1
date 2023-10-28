using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.ReviewSprint1.V22.Lib;

namespace Tiuiu.SikachevaEA.ReviewSprint1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            double z = 1.588;
            Assert.AreEqual(z, res);
        }
    }
}
