using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task3.V30.Lib
{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[,] resultMatrix = (int[,])matrix.Clone();


            int fifthRowIndex = 4;

            for (int j = 0; j < cols; j++)
            {
                if (resultMatrix[fifthRowIndex, j] % 2 == 0)
                {
                    resultMatrix[fifthRowIndex, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}