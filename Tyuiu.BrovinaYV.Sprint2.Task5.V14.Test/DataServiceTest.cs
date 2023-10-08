using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.BrovinaYV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(1, 2));
            Assert.AreEqual("Среда", ds.FindDayName(2, 2));
            Assert.AreEqual("Четверг", ds.FindDayName(1, 4));
            Assert.AreEqual("Пятница", ds.FindDayName(20, 7));
            Assert.AreEqual("Суббота", ds.FindDayName(13, 8));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 15));

            Assert.ThrowsException<ArgumentException>(() =>
                {
                    ds.FindDayName(0, 0);
                });
           
        }

    }
    
}
