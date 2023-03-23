using System.Globalization;

namespace WorkWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вывод");
            Console.WriteLine(a + b);
            if (a >= 0 &&
                (b <= 5 ||
                b > 3))
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(a / b);
            if (a % b != 0)
            {
                Console.WriteLine(a % b + " остаток от деления");
                Console.WriteLine($"{a % b} остаток от деления"); // тоже самое 
            }
            //if (double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any,CultureInfo.GetCultureInfo("en-GB"), out var c))
            if (double.TryParse(Console.ReadLine().Replace('.', ','), out var c))// тоже самое
                {
                Console.WriteLine($"{c} третье значение");
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
    }
}