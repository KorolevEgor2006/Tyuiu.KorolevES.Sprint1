using Tyuiu.KorolevES.Sprint1.Task1.V12.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateValid()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}