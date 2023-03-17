using System.Collections.Generic;

namespace Test_1
{
    internal class Program
    {
        static void Sum(int A, int B)
        {
            Console.WriteLine(A + B);
        }
        static void WriteMyList(List<object> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Sum(2,3);
            Console.Write("Hello, World!\n\r");
            Console.WriteLine("Stringe");
            Console.WriteLine("Stringe");
            Console.WriteLine(12);
            ////var tt = Console.ReadLine();//
            ////Console.Write(tt);
            ////Guid guid = Guid.NewGuid();
            ////Console.WriteLine(guid.ToString());

            //Условия
            //bool e = false;
            //if (e)
            //{
            //    Console.WriteLine("ya");
            //    Console.WriteLine("oi");
            //}
            //else if (false)
            //{
            //    Console.WriteLine("rr");
            //}
            //else 
            //{
            //    if (true)
            //    {
            //        Console.WriteLine("UU");
            //    }
            //    Console.WriteLine("TT");
            //}
            //e = true;
            //if (e)
            //{
            //    Console.WriteLine(e);
            //}

            //Циклы
            int count = 0;
            //while (count <= 12) 
            //{
            //    Console.WriteLine(count);
            //    count = count + 1;
            //    //if (count > 12)
            //    //{
            //    //    break;
            //    //} 
            //}
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var x in "Стол")
            //{
            //    Console.WriteLine(x);
            //}
            //string Y = "Стул МашинаРАД";
            //for (int i = 0; i < Y.Length; i++)// i+=1(прибовляет после действия), ++i(прибовляет перед действием) 
            //{
            //    if (Y[i] == 'ш')
            //    {
            //       Y= Y.Replace('ш', 'о');
            //    }    
            //    Console.Write(Y[i]);
            //}

            //Массивы
            //int[] mas1 = new int[10] {2,3,1,2,3,4,5,6,7,8};
            //for (int i = 0; i<mas1.Length; i++)
            //    {
            //    //i = i + 10;//(здесь мы вышлим за границы массива т.е. ошибка)
            //    count += mas1[i];//count = mas1[i]+count; 

            //    Console.WriteLine(count);
            //}

            //Списки
            List<object> list = new List<object>() {2, 3, 1, 2, 3, 4, 5, 6, 7, 8};
            ////for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //} 
            list.Add(5);//Добовляем элемент в список
            list.Insert(5, 99);//Вставить на определенную позицию
            Console.WriteLine("*");
            WriteMyList(list);
            Console.WriteLine("*");
            int Tor = list.Count;//Узнаем кол.элементов
            Console.WriteLine(Tor);
            for (int i = 0; i < Tor; i++)//Добавить элементы в список цикл
            {
                if (i>1)
                {
                    list.Add(99);
                }   
            }
            WriteMyList(list);
            ////foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine();
            for (int i = 0; i < Tor; i++)
            {
                if (i > 1)
                {
                    list.Insert(i,99);
                }
            }
            WriteMyList(list);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            List<object> tyu = new List<object>() { 12, 2 };
            List<object> ty = new List<object>() { "руиоакри,рцогиашц", "wetyufvwuy"};
            List<object> tre = new List<object>() { 't', 'w' };
            Console.WriteLine("Вывод списков");
            WriteMyList(tyu);
            WriteMyList(ty);
            WriteMyList(tre);
            //List, Console(класс), Write, write line, add, insert(методы), tyu, ty, tre(переменные), object, int, string, char(тип данных)
            //for, foreach (циклы), if (условия).
        }
    }
}