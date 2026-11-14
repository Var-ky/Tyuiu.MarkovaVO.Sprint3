using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovaVO.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int istart, int kstart, int istop, int kstop)
        {
            double sumSeries = 0;
            int i;
            int k;
            for (i = istart; i <= istop; i++)
            {
                for (k = kstart; k <= kstop; k++)
                {
                    sumSeries = sumSeries + (Math.Pow(x, k)+Math.Cos(k));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
