using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovaVO.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;
            while (i <= stopValue)
            {
                p = p * Math.Pow(2 / (Math.Cos(value) ), i);
                i += 1;
            }
            return Math.Round(p, 3);
        }
    }
}
