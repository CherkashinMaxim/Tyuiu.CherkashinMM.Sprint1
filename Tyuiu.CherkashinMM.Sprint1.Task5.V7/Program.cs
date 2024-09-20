using Tyuiu.CherkashinMM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Черкашин М. М. | ИИПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток        *");
            Console.WriteLine("* до того момента (в первой половине дня), когда часовая стрелка          *");
            Console.WriteLine("* повернулась на f градусов (0<f<360, f – вещественное число)             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int f;
            Console.WriteLine("Введите число f:");
            f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.AngleToHoursMinutes(f));
            Console.ReadLine();
        }
    }
}
