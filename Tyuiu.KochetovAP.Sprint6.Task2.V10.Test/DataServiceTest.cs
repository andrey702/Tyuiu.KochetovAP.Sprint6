using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint6.Task2.V10.Lib;
using System;

namespace Tyuiu.KochetovAP.Sprint6.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            double sinMinus5 = Math.Sin(-5); 
            double calcMinus5 = 2 * (-5) - 4 + (2 * (-5) - 1) / (sinMinus5 + 1);
            calcMinus5 = Math.Round(calcMinus5, 2);

            double sin0 = Math.Sin(0);
            double calc0 = 2 * 0 - 4 + (2 * 0 - 1) / (sin0 + 1);
            calc0 = Math.Round(calc0, 2);

            double sin5 = Math.Sin(5);
            double calc5 = 2 * 5 - 4 + (2 * 5 - 1) / (sin5 + 1);
            calc5 = Math.Round(calc5, 2);

            Assert.AreEqual(calcMinus5, res[0], 0.01, $"x=-5: ожидалось {calcMinus5}, получено {res[0]}");
            Assert.AreEqual(calc0, res[5], 0.01, $"x=0: ожидалось {calc0}, получено {res[5]}");
            Assert.AreEqual(calc5, res[10], 0.01, $"x=5: ожидалось {calc5}, получено {res[10]}");
        }
    }
}