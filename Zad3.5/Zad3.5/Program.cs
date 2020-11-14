using System;

namespace Zad3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x0, delta;

            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - (4 * a * c);

            if (delta > 0)
            {
                delta = Math.Sqrt(delta);
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
                Console.WriteLine("Są dwa pierwiastki równania:{0} oraz {1} ",x1, x2);

            }
            else if (delta == 0)
            {
                x0 = -b / (2 * a);
                Console.WriteLine("Jest jeden pierwiastek x0:{0} ", x0);
            }
            else
                Console.WriteLine("Brak pierwiastków!");
        }
    }
}
