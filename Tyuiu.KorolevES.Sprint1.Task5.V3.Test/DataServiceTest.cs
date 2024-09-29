using Tyuiu.KorolevES.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpossions()
        {
            int k = 130985;

            DataService ds = new DataService();
            int h = ds.Calculate(k);
            int res = 9;
            Assert.AreEqual(res, h);
        }
    }
}