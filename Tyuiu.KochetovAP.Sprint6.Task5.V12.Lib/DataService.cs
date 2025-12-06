using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            string fullPath = path;
            if (!Path.IsPathRooted(path))
            {
                fullPath = Path.Combine(@"C:\DataSprint6\", path);
            }

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"Файл не найден: {fullPath}");
            }

            using (StreamReader reader = new StreamReader(fullPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Replace(',', '.');

                    string[] values = line.Split(new[] { ' ', '\t', ';' },
                                                StringSplitOptions.RemoveEmptyEntries);

                    foreach (string value in values)
                    {
                        if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                        {
                            numbers.Add(Math.Round(number, 3));
                        }
                    }
                }
            }

            return numbers.ToArray(); 

        }
    }
}
