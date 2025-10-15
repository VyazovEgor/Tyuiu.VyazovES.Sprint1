using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VyazovES.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int x)
        { 
            return ((x - 1) % 7) + 1;

        }

    }
}


