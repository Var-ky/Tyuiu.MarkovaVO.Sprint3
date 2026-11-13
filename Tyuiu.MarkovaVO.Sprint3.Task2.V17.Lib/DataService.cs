using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovaVO.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            do
            {
                sumSeries = sumSeries + Math.Pow(1 / (Math.Cos(i) + 2), 2);
                i++;
            }while (i <= stopValue) ;

            return Math.Round(sumSeries, 3);
        }
    }
}
