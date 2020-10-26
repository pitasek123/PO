using System;

namespace Zadanie_2._3
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
            Console.WriteLine("Twoje BMI wynosi: ");
            Console.WriteLine(bmi);
            Console.ReadKey();

            
        }
    }
}
