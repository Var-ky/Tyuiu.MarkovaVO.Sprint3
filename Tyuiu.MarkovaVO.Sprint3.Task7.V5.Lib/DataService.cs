using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovaVO.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = (stopValue - startValue) + 1;
            double[] res = new double[size];
            int index = 0;
            double y;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                }
                y = Math.Round(y, 2);
                res[index] = y;
                index += 1;
            }
            return res;
        }
    }
}
