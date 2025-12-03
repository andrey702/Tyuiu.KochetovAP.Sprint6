using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double y = 0;

                double sinX = Math.Sin(x);
                double denominator = sinX + 1;

                if (Math.Abs(denominator) > 0.0001)
                {
                    y = 2 * x - 4 + (2 * x - 1) / denominator;
                    y = Math.Round(y, 2);
                }

                result[i] = y;
            }

            return result;
        }
    }
}