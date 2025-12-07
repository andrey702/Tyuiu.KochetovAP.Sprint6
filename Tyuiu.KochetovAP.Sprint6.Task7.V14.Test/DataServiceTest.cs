using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task7.V14.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V14.csv";

            string[] lines =
            {
                "1;2;3;4",
                "5;6;7;8",
                "9;10;11;12"
            };

            Directory.CreateDirectory(@"C:\DataSprint6");
            File.WriteAllLines(path, lines);

            
            int[,] matrix = ds.GetMatrix(path);

            
            Assert.AreEqual(44, matrix[1, 1]);
            Assert.AreEqual(44, matrix[1, 3]); 
            Assert.AreEqual(5, matrix[1, 0]);  
            Assert.AreEqual(7, matrix[1, 2]);  

            File.Delete(path);
        }
    }
}