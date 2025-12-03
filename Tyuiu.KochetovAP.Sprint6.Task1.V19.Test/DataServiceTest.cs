using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint6.Task1.V19.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(11, result.Length);

          
            Assert.AreEqual(0, result[3], "Ошибка при делении на ноль (x = -2)");

       
            Assert.AreEqual(1.50, result[5], 0.001, "Ошибка при x = 0");

           
            Assert.AreEqual(-14.68, result[10], 0.01, "Ошибка при x = 5");

           
            Assert.AreEqual(15.19, result[0], 0.01, "Ошибка при x = -5");
        }
    }
}