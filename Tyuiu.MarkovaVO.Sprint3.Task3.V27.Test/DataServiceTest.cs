using Newtonsoft.Json.Linq;
using Tyuiu.MarkovaVO.Sprint3.Task3.V27.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";

            int res = ds.ConvertStringToInt(value);
            int wait = 567;
            Assert.AreEqual(wait, res);
        }
    }
}
