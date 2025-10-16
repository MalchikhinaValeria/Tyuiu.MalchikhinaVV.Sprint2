using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint2.Task4.V4.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 12.141;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 23.346;
            Assert.AreEqual(wait, res);
        }
    }
}
