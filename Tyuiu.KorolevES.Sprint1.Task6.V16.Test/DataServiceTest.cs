using Tyuiu.KorolevES.Sprint1.Task6.V16.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            string text = "Hello World!?";
            bool res = ds.CheckSpecSymbols(text);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}