using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint2.Task2.V11.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 13;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
