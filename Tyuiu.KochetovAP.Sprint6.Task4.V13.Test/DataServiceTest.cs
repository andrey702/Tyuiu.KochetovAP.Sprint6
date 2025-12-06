using System.Globalization;
using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task4.V13.Lib;

namespace Tyuiu.KochetovAP.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, result.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidStartStop()
        {
            DataService ds = new DataService();
            ds.GetMassFunction(5, -5);
        }

        [TestMethod]
        public void ValidSaveToFile()
        {
            DataService ds = new DataService();
            string fileName = "TestOutput.txt";


            ds.SaveToFile(fileName, -2, 2);


            string fullPath = @"C:\DataSprint6\TestOutput.txt";
            Assert.IsTrue(File.Exists(fullPath), $"Файл не найден: {fullPath}");


            string content = File.ReadAllText(fullPath);
            Assert.IsTrue(content.Contains("x\tF(x)"));

            File.Delete(fullPath);
        }

        [TestMethod]
        public void CheckDirectoryCreation()
        {
            string directory = @"C:\DataSprint6\";
т
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory, true);
            }

            DataService ds = new DataService();
            ds.SaveToFile("test.txt", 0, 0);

            Assert.IsTrue(Directory.Exists(directory), $"Директория не создана: {directory}");

            string filePath = Path.Combine(directory, "test.txt");
            Assert.IsTrue(File.Exists(filePath), $"Файл не создан: {filePath}");


            File.Delete(filePath);


            try
            {
                Directory.Delete(directory);
            }
            catch
            {

            }
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(3, 3);
            Assert.AreEqual(1, result.Length);
        }

        [TestMethod]
        public void CheckRounding()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 1);


            Assert.AreEqual(4.35, result[0], 0.001);


            string rounded = result[0].ToString("F2", CultureInfo.InvariantCulture);
            Assert.AreEqual("4.35", rounded);
        }

        [TestMethod]
        public void CheckFunctionAtZero()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(0, 0);
            Assert.AreEqual(2.00, result[0], 0.001);
        }

        [TestMethod]
        public void CheckFileContent()
        {
            DataService ds = new DataService();
            string fileName = "ContentTest.txt";

            ds.SaveToFile(fileName, 0, 2);

            string fullPath = @"C:\DataSprint6\ContentTest.txt";
            string[] lines = File.ReadAllLines(fullPath);


            Assert.AreEqual("x\tF(x)", lines[0]);


            Assert.AreEqual(4, lines.Length);


            File.Delete(fullPath);
        }
    }
}