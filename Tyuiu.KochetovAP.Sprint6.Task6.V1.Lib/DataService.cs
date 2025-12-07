using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length > 0)
                        {
                            result += words[0] + " ";
                        }
                    }
                }

                return result.Trim();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обработки файла: {ex.Message}");
            }
        }
    }
}