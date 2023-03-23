namespace RefOut
{
    internal class Program
    {
        static void AddSymbol(ref string a)
        {
            a = a + "fff";
        }
        static void Main(string[] args)
        {
            string? text = Console.ReadLine();
            AddSymbol(ref text);
            Console.WriteLine(text);
        }
    }
}