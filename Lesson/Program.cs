namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue<string> pr = new Queue<string>(); //Очередь

            //pr.Enqueue("Я");
            //pr.Enqueue("Ты");
            //pr.Enqueue("Мы");
            //pr.Enqueue("Вы");

            //foreach (var ee in pr)  // Посмотреть очередь
            //{
            //    Console.WriteLine(ee);
            //}

            //Console.WriteLine("Сейчас очередь -" + pr.Dequeue()); //Извлекаем и возвращаем первый эллемент нашей очереди
            //Console.WriteLine("Следующий в очереди -" +pr.Peek()); //Получение без удаления (в отличии от Dequeue)




            //Stack<int> numbers = new Stack<int>();

            //numbers.Push(0);//Добавление эллемента
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);

            //while (numbers.Count > 0) //Получаем эллемены, можно так же через foreach
            //{
            //Console.WriteLine("Следующее число в стеке - " + numbers.Pop());
            //}



            Dictionary<string, string> countries = new Dictionary<string, string>();//Словарь
            countries.Add("Россия", "Москва");//Добовляем КЛЮЧ(Россия) Значение(Москва)
            countries.Add("Япония", "Токио");
            countries.Add("Австралия", "Сидней");

            foreach (var item in countries)//Перебор 
            {
                Console.WriteLine($"Страна - {item.Key}, столица - {item.Value}");
            }



            if (countries.ContainsKey("Росся")) //Проверка есть ли такой КЛЮЧ
            Console.WriteLine(countries["Россия"]);


        }
    }
}