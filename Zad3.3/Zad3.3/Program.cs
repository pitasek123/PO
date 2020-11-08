using System;

namespace Zad3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("{0} to największa liczba", a);
            if (b > a && b > c)
                Console.WriteLine("{0} to największa liczba", b);
            if (c > a && c > b)
                Console.WriteLine("{0} to największa liczba", c);
            else if (a == b || a == c || b == c)
                Console.WriteLine("{0} to największa liczba", a, b, c);


        }
    }
}
