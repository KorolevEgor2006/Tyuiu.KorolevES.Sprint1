using Tyuiu.KorolevES.Sprint1.Task7.V16.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.022;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}