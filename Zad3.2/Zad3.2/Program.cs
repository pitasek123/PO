using System;

namespace Zad3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
                Console.WriteLine("Nie można dzielić przez 0!");
            else
            {
                if (a % b == 0)
                {
                    Console.WriteLine("Liczba jest dzielnikiem!");
                }
                else
                    Console.WriteLine("Liczba nie jest dzielniiem!");
            }
        }
    }
}
