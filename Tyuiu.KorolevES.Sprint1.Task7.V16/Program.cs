using Tyuiu.KorolevES.Sprint1.Task7.V16.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите      *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*          ___   cos(x^2)       _____                                     *");
            Console.WriteLine("*  Z= sin(/x^2) + ------ - sin(/x^2-1)                                    *");
            Console.WriteLine("*                3*x^3                                                    *");
            Console.WriteLine("Введите число X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            if (x != 0)
            {
                Console.WriteLine(ds.Calculate(x));
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            Console.ReadKey();

        }
    }
}
