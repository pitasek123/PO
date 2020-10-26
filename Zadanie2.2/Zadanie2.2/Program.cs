using System;

namespace Zadanie2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - (4 * a * c);
            Console.WriteLine("Delta wynosi: ");
            Console.WriteLine(delta);
            Console.ReadKey();
        }
    }
}
