using Tyuiu.MarkovaVO.Sprint3.Task5.V25.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int istart = 1;
            int kstart = 1;
            int istop = 3;
            int kstop = 10;
            double res = ds.GetSumSumSeries(x, istart, kstart, istop, kstop);
            double wait = 6133.748;
            Assert.AreEqual(wait, res);
        }
    }
}
