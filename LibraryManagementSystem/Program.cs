namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = {
                { "Булгаков", "Брэдбери", "Кинг" },
                { "Роулинг", "Ремарк", "Киз" },
                { "Достоевский", "Оруэлл", "Уайльд" } };
            while ( isOpen )
            {
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать, что за книга, зная ее индекс.\n\n2 - Найти книгу по автору.\n\n3 - Вывести все книги.\n\n4 - Выход.");
                Console.Write("Введите пункт меню:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;
                        Console.Write("Введите номер полки:");
                        rows = Convert.ToInt32(Console.ReadLine()) -1;
                        Console.Write("Введите порядкойвый номер");
                        cols = Convert.ToInt32(Console.ReadLine()) -1;
                        Console.WriteLine("\nЭто книга - " + books[rows,cols]);
                        break;
                    case 2:
                        string autor;
                        bool autorIsFind = false;
                        Console.Write("\nВведите нужного автора:");
                        autor = Console.ReadLine();

                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (autor.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write("Автор - " + books[i, j] + " Находиться по адрессу: " + " Ряд - " + (i+1) + "|" + "Столбец - " + (j+1));
                                    autorIsFind |= true;
                                }
                            }
                        }
                        if (autorIsFind == false)
                        {
                            Console.WriteLine("Такого автора нет.");
                        } 
                        break;
                    case 3:
                        Console.WriteLine("\nВесь список авторов.\n");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.Write("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}