using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }


            for (int j = 0; j < cols; j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 44;
                }
            }

            return matrix;
        }
    }
}
