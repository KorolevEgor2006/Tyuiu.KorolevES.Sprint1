using Tyuiu.KorolevES.Sprint1.Task2.V23.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestConvertMinutesToSecondsValid()
        {
            DataService ds = new DataService();
            int minutes = 10;
            int res = ds.ConvertMinutesToSeconds(minutes);
            Assert.AreEqual(600, res);
        }
    }
}