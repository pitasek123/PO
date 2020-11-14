using System;

namespace Zad3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, wzrost, bmi;
            Console.WriteLine("Podaj masę w kilogramach: ");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = float.Parse(Console.ReadLine());
            bmi = masa / wzrost;

            if (bmi < 18.5)
                Console.WriteLine("Niedowaga!");
            else if (bmi >= 18.5 && bmi < 25)
                Console.WriteLine("Waga prawidłowa!");
            else
                Console.WriteLine("Nadwaga!");
            
        }
    }
}
