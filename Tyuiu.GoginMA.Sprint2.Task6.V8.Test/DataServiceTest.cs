using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoginMA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.GoginMA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDate1()
        {
            DataService ds = new DataService();
            int n = 1;
            int m = 2;
            string wait = "31.01";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void FindDate2()
        {
            DataService ds = new DataService();
            int n = 21;
            int m = 2;
            string wait = "20.02";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void FindDate3()
        {
            DataService ds = new DataService();
            int n = 7;
            int m = 2;
            string wait = "06.02";
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
