using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint2.Task7.V13.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 2;

            bool res = ds.CheckDotInShadedArea(x,y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
