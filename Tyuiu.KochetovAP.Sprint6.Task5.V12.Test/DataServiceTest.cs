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
            string testDir = @"C:\DataSprint6\Test";
            string path = Path.Combine(testDir, "TestInput.txt");

            if (!Directory.Exists(testDir))
            {
                Directory.CreateDirectory(testDir);
            }

            File.WriteAllText(path, "-13.0 -19.0 -9.82 13.0 11.49 -9.71 3.36 10.0 14.52 16.0 13.66 0.48 4.13 -0.11 19.0 -17.36 11.0 11.28 -12.0 -12.35");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(20, result.Length);
            Assert.AreEqual(-13.0, result[0], 0.001);
            Assert.AreEqual(10.0, result[7], 0.001);

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
        public void ValidLoadFromDataFile_WithoutRounding()
        {
            string testDir = @"C:\DataSprint6\Test";
            string path = Path.Combine(testDir, "TestNoRound.txt");

            if (!Directory.Exists(testDir))
            {
                Directory.CreateDirectory(testDir);
            }

            File.WriteAllText(path, "3.1415 2.7182");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3.1415, result[0], 0.0001);
            Assert.AreEqual(2.7182, result[1], 0.0001);

            File.Delete(path);
        }
    }
}