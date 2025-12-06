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

            File.WriteAllText(path, "10.5 20.3 30.7");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(10.5, result[0], 0.001);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidLoadFromDataFile()
        {
            DataService ds = new DataService();
            ds.LoadFromDataFile(@"C:\DataSprint6\NonExistent.txt");
        }

        [TestMethod]
        public void ValidLoadFromDataFile_Rounding()
        {
            string path = @"C:\DataSprint6\TestRounding.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "1.23456 2.34567");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(1.235, result[0], 0.001);
            Assert.AreEqual(2.346, result[1], 0.001);

            File.Delete(path);
        }
    }
}