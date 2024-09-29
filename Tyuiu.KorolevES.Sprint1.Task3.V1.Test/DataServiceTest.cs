using Tyuiu.KorolevES.Sprint1.Task3.V1.Lib;

namespace Tyuiu.KorolevES.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 1.004777;
            double res = 3.157;
            double mres = ds.CylinderVolume(r, h);
            Assert.AreEqual(res, mres);
        }
    }
}