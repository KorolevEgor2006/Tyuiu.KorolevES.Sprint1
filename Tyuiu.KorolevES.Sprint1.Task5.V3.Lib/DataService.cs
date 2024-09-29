using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorolevES.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string s = Convert.ToString(k).Substring(Convert.ToString(k).Length - 3);
            return Convert.ToInt32(s.Substring(0,1));
        }
    }
}
