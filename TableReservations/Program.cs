using System;

namespace TableReservations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            int[] tables = {7, 5 , 4, 3, 2, 1};
            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine("За столом " + (i + 1) + "свободно " + tables[i] + "мест.");
                }

                Console.SetCursorPosition (0, 0);
                Console.WriteLine("Администрирование кафе.");
                Console.WriteLine("\n\n1 - забронировать место. \n\n2 - выход из программы.");
                Console.Write("\nВведите номер команды");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                   case 1:
                        int userTable, userPlase;
                        Console.Write("За каким столом вы хотите забронировать место:");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (tables.Length <= userTable || userTable < 0)
                        {
                            Console.WriteLine("Такого стола нет.");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать:");
                        userPlase = Convert.ToInt32(Console.ReadLine());

                        if (tables[userTable] < userPlase || userPlase < 0)
                        {
                            Console.WriteLine("Недостаточно мест.");
                            break;
                        }
                        tables[userTable] -= userPlase;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
            }   Console.ReadKey();
                Console.Clear();
        }
    }
}