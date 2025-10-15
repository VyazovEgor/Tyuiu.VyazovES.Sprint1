using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.VyazovES.Sprint1.Task1.V23.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double x, double a)
        {
            double Pi = 3.14;
            return (x * Pi) / (2 * a);

        }

    }
}
