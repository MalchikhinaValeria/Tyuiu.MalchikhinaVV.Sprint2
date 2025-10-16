using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint2.Task6.V10.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 2003;
            int m = 1;
            int n = 26;

            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "2003-1-25";

            Assert.AreEqual(wait,res);

        }
    }
}
