﻿using Tyuiu.KorolevES.Sprint1.Task1.V12.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (x+y)/6 и печатает его на экране.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
