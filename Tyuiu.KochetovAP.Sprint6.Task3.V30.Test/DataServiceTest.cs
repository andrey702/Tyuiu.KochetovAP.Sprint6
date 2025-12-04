using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint6.Task3.V30.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -9,  -4,  17,  -1, -20 },
                { -19,  18,  -4,   2,  14 },
                { -12,  16,  -2,   7,  18 },
                { -16,  15,   4, -12, -13 },
                { -15,  -4, -16,   1, -14 }
            };

            int[,] result = ds.Calculate(matrix);

            
            Assert.AreEqual(-15, result[4, 0]);
            Assert.AreEqual(0, result[4, 1]);  
            Assert.AreEqual(0, result[4, 2]);  
            Assert.AreEqual(1, result[4, 3]);   
            Assert.AreEqual(0, result[4, 4]);   
        }
    }
}