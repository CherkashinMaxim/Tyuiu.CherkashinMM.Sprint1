using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.CherkashinMM.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task1V24 
    {
        public int Calculate(double value, int valueTwo)
        {
            return ((int)value - valueTwo) * ((int)value - valueTwo);
        }
    }
}