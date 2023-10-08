using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint2.Task4.V23.Lib;

namespace Tyuiu.BrovinaYV.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 81;
            double res = ds.Calculate(x, y);
            double wait = 1.001;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 56.75;
            Assert.AreEqual(res, wait);
        }
    }
}
