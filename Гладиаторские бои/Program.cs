using System;

namespace Гладиаторские_бои
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float healtf1 = rand.Next(90, 100);
            int damage1 = rand.Next(5, 25);
            int armor1 = rand.Next(20, 70);
            float healtf2 = rand.Next(85, 135); 
            int damage2 = rand.Next(10, 40);
            int armor2 = rand.Next(40, 100);
             
            Console.WriteLine("Гладиатор 1 - " + healtf1 + " жизни, " + damage1 + " Больший урон " + armor1 + " Защита");
            Console.WriteLine("Гладиатор 2 - " + healtf2 + " жизни, " + damage2 + " Больший урон " + armor2 + " Защита");
            while (healtf1 > 0 && healtf2 > 0)
            {
                healtf1 -= Convert.ToSingle (rand.Next(0, damage2)) / 100 * armor1;
                healtf2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;
                Console.WriteLine("Гладиатор 1 - " + healtf1 + ".");
                Console.WriteLine("Гладиатор 2 - " + healtf2 + ".");
            }
            
            if (healtf1 <= 0 && healtf2 <=0)
            {
                Console.WriteLine("Ничья, все погибли");
            }
            else if ( healtf1 <=0)
            {
                Console.WriteLine("Гладиатор 1 погиб");
            }
            else if (healtf2 <=0)
            {
                Console.WriteLine("Гладиатор 2 погиб");
            }    
            }
    }
}