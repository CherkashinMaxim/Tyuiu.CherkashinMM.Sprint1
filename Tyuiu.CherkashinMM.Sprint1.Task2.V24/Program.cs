using Tyuiu.CherkashinMM.Sprint1.Task2.V24.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(num1, num2));
            Console.ReadLine();
        }
    }
}
