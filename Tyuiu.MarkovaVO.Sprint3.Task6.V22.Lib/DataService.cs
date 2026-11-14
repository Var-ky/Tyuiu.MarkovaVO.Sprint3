using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MarkovaVO.Sprint3.Task6.V22.Lib
{
    public class DataService : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int del = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d =1; d <= stopValue; d++ )
                {
                    if (x % d == 0)
                    {
                        del += 1;
                    }
                }    
            }
            return del;
        }
    }
}
