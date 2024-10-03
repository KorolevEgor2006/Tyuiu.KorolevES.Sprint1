using Tyuiu.KorolevES.Sprint1.Task6.V16.Lib;
namespace Tyuiu.KorolevES.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Королев Е. С.| АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке  *");
            Console.WriteLine("* есть восклицание (!) и вопрос (?).                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст для проверки наличия ! и ?:");
            string textcheck = Console.ReadLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            DataService ds = new DataService();
            Console.WriteLine(ds.CheckSpecSymbols(textcheck));
            Console.ReadKey();
        }
    }
}
