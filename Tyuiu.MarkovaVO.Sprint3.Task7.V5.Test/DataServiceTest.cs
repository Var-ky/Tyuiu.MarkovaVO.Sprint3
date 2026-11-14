using Tyuiu.MarkovaVO.Sprint3.Task7.V5.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] wait = [70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83];
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
