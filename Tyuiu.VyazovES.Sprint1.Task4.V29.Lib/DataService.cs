using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VyazovES.Sprint1.Task4.V29.Lib
{
    public class DataService : ISprint1Task4V29
    {
        public double Calculate(double x, double y)
        {
            double a = (Math.Sqrt(2+Math.Abs(x-2*y))) / 3 * x * y * y ;

            return Math.Round(a, 3);

        }
    }
}
