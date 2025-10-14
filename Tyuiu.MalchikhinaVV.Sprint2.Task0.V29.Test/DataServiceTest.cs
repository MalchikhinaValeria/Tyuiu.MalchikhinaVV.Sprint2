using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint2.Task0.V29.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 735;
            bool[] wait = new bool[6] {false,false,true,true, false, false};


            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);

         


        }
    }
}
