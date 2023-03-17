namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            string Bd = Console.ReadLine();
            if (Bd.Equals("monday", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(1);
            }
            else if (Bd.Equals("tus", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(2);
            }
            else 
            { 
                Console.WriteLine(3);
            }


            
           
        }
    }
}