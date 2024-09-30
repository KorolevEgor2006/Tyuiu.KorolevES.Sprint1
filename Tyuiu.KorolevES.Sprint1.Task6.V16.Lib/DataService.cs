using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorolevES.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            int s1 = 0;
            int s2 = 0;
            foreach(char i in value)
            {
                if (i == '!')
                {
                    s1 = 1;
                }
                if (i == '?')
                {
                    s2 = 1;
                }
            }
            if( s2 == 1 && s1 ==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
