using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\TestInput.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "-13.0 -19.0 -9.82 13.0 11.49 -9.71 3.36 10.0 14.52 16.0");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(9, result.Length); 
            Assert.AreEqual(-13.0, result[0], 0.001);
            Assert.AreEqual(14.52, result[7], 0.001); 

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidLoadFromDataFile()
        {
            DataService ds = new DataService();
            ds.LoadFromDataFile(@"C:\DataSprint6\NonExistent.txt");
        }
    }
}