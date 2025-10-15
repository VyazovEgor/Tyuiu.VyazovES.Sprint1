using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.VyazovES.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13 
    {

        public double MultiplyOfDigits(double x)
        {
            x = GetDigitProduct(x);
            return Math.Round(x, 3);
        }

        static double GetDigitProduct(double number)
        {
            // Преобразуем число в строку для извлечения цифр
            string numberStr = number.ToString("F10", System.Globalization.CultureInfo.InvariantCulture);

            double product = 1;
            int digitCount = 0;
            bool foundDecimalPoint = false;

            foreach (char c in numberStr)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    product *= digit;
                    digitCount++;

                    // Ограничиваемся тремя цифрами для трехзначного числа
                    if (digitCount >= 3 && !foundDecimalPoint)
                        break;
                }
                else if (c == '.' || c == ',')
                {
                    foundDecimalPoint = true;
                    // Для дробных чисел берем первые 3 цифры после запятой
                    digitCount = 0;
                }

                // Для дробных чисел ограничиваемся тремя цифрами после запятой
                if (foundDecimalPoint && digitCount >= 3)
                    break;
            }

            return product;
        }

    }
}
