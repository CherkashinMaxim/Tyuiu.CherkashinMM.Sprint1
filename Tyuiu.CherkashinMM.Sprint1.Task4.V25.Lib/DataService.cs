using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.CherkashinMM.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double x)
        {
            //x = x * Math.PI / 180;

            return Math.Round((1-Math.Cos(x))/(Math.Sin(x)*Math.Sin(x)), 3);
        }
    }
}
