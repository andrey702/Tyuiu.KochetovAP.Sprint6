
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"Файл не найден: {path}");
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        // Заменяем запятые на точки для унификации
                        line = line.Replace(',', '.');

                        string[] values = line.Split(new[] { ' ', '\t', ';' },
                                                    StringSplitOptions.RemoveEmptyEntries);

                        foreach (string value in values)
                        {
                            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                            {
                                // Фильтруем сразу - добавляем только числа не кратные 5
                                if (Math.Abs(number % 5) > 0.0001)
                                {
                                    numbers.Add(number);
                                }
                            }
                        }
                    }
                }

                return numbers.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}

