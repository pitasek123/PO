using System;

namespace Zadanie_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza: ");
            C = double.Parse(Console.ReadLine());
            F = 32 + (1.8 * C);
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
