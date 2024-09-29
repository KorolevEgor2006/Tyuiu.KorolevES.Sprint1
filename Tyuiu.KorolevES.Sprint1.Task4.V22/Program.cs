using Tyuiu.KorolevES.Sprint1.Task4.V22.Lib;

namespace Tyuiu.KorolevES.Sprint1.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. Ответ          *");
            Console.WriteLine("* округлите до 3 знаков после запятой.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            
            if (x * y >= 0)
            {
                Console.WriteLine(ds.Calculate(x, y));
            }
            else
            {
                Console.WriteLine("Нельзя извлечь квадратный корень из отрицательного числа.");
            }
        }
    }
}
