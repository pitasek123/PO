using System;

namespace Zad3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok do sprawdzenia: ");
            rok = int.Parse(Console.ReadLine());

            if ((rok % 4 == 0) && (rok % 100 != 0))
            {
                Console.WriteLine("Rok jest przestępny!");
            }
            else if(rok % 400 == 0)
            {
                Console.WriteLine("Rok jest przestępny!");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny!");
            }
        }
    }
}
