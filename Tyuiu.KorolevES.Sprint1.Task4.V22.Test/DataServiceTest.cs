using Tyuiu.KorolevES.Sprint1.Task4.V22.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = 0.1;
            double mres = ds.Calculate(x, y);
            Assert.AreEqual(res, mres);
        }
    }
}