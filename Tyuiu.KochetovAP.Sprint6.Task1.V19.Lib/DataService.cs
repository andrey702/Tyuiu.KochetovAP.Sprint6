using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KochetovAP.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;

               
                if (x == -2)
                {
                    resultArray[i] = 0;
                    continue;
                }

                try
                {
                   
                    double cosX = Math.Cos(x);
                    double denominator = x + 2;

                   
                    double y = cosX + (cosX / denominator) - (3 * x);

                    
                    resultArray[i] = Math.Round(y, 2);
                }
                catch
                {
                    resultArray[i] = 0;
                }
            }

            return resultArray;
        }
    }
}
