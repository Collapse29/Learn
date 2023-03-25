namespace StackQueueDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string,string>();
            dic.Add("1", "qwe");
            dic["2"] = "nje";
            dic["1"] = "eww";
            dic.TryGetValue("3", out var c);
            foreach(var i in dic)
            {
                Console.WriteLine($"Ключ: {i.Key}, Значение: {i.Value}");
            }
            dic.Add("1", "eee");//Будет ошибка так как с ключом 1 элемент уже добавлен 
        
        }
    }
}