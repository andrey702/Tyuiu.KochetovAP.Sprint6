using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("startValue > stopValue");
            }

            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;

                if (Math.Abs(denominator) < 0.0001)
                {
                    result[index] = 0;
                }
                else
                {
                    double value = 3 * x + 2 - (x / denominator);
                    result[index] = Math.Round(value, 2);
                }
                index++;
            }

            return result;
        }

        public void SaveToFile(string savePath, int startValue, int stopValue)
        {
            string directory = @"C:\DataSprint6\";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string fullPath = Path.Combine(directory, savePath);
            double[] values = GetMassFunction(startValue, stopValue);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("x\tF(x)");
                for (int i = 0; i < values.Length; i++)
                {
                    writer.WriteLine($"{startValue + i}\t{values[i]}");
                }

            }
        }
    }
}
