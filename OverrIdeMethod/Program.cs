namespace OverrIdeMethod
{
    internal class Program
    {
        /// <summary>
        /// Метод складывающий double
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        static double Sum(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        /// <summary>
        /// Метод складывающий int
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        static int Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        /// <summary>
        /// Метод складывающий float
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        static float Sum(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        /// <summary>
        /// Метод складывающий long
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        static long Sum(long a, long b)
        {
            long sum = a + b;
            Console.WriteLine(sum);// Можно без него 
            return sum;
        }
        /// <summary>
        /// Метод складывает строки 
        /// </summary>
        /// <param name="a">Первая строка</param>
        /// <param name="b">Вторая строка</param>
        /// <param name="space">Необязательный параметр разделитель</param>
        /// <returns>Возвращаемое значение</returns>
        static string Sum(string a, string b, string space = " ")
        {
            string sum = a + space + b;
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
            //var a = Convert.ToInt32(Console.ReadLine());
            //var b = Convert.ToInt32(Console.ReadLine());
            //var sum = Sum(a,b);
            var x = Console.ReadLine();
        
            var y = Console.ReadLine();
            Console.WriteLine(Sum(x,y));
        }
    }
}