using Tyuiu.MitinNV.Sprint3.Task0.V3.Lib;
namespace Tyuiu.MitinNV.Sprint3.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет сумму ряда по фо*");
            Console.WriteLine("*ормуле                                                                   *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            var result = ds.GetSumSeries(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}