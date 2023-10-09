using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint2.Task7.V11.Lib;

namespace Tyuiu.BrovinaYV.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea1()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }


        [TestMethod]
        public void ValidCheckDotInShadeArea2()
        {
            DataService ds = new DataService();
            double x = 0.9;
            double y =- 0.1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(res, wait);
        }

    }
}
