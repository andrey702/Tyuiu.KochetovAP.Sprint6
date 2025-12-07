using System.IO;
using Tyuiu.KochetovAP.Sprint6.Task6.V1.Lib;
namespace Tyuiu.KochetovAP.Sprint6.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\TestFile.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "Привет мир\nЭто тестовая строка\nТретья строка\n\nПоследняя строка");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("Привет Это Третья Последняя", result);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidCollectTextFromFile_EmptyLines()
        {
            string path = @"C:\DataSprint6\TestEmpty.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "\n\nСлово1\n\nСлово2\n\n");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("Слово1 Слово2", result);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidCollectTextFromFile_SingleWord()
        {
            string path = @"C:\DataSprint6\TestSingle.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "Один\nДва\nТри");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("Один Два Три", result);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidCollectTextFromFile_NotFound()
        {
            DataService ds = new DataService();
            ds.CollectTextFromFile(@"C:\DataSprint6\NotExist.txt");
        }

        [TestMethod]
        public void ValidCollectTextFromFile_WithTabs()
        {
            string path = @"C:\DataSprint6\TestTabs.txt";

            if (!Directory.Exists(@"C:\DataSprint6\"))
            {
                Directory.CreateDirectory(@"C:\DataSprint6\");
            }

            File.WriteAllText(path, "First\tSecond\nWord1\tWord2");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("First Word1", result);

            File.Delete(path);
        }
    }
}