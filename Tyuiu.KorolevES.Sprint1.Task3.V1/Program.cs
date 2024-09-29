using Tyuiu.KorolevES.Sprint1.Task3.V1.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Опператоры составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Объявите необходимые переменные и напишите программу вычисления объема  *");
            Console.WriteLine("* цилиндра, предполагающий ввод исходных данных. Ответ округлите до 3     *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите раддиус цилиндра:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра:");
            double h = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine(ds.CylinderVolume(r, h));
            Console.ReadKey();
        }
    }
}
