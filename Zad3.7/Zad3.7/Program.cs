using System;

namespace Zad3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dzien=0;
            
            Console.WriteLine("Podaj numer tygodnia!: ");
            dzien = int.Parse(Console.ReadLine());

            switch(dzien)
            {
                case 1:
                    Console.WriteLine("Podany dzień to Poniedziałek!");
                    break;
                case 2:
                    Console.WriteLine("Podany dzień to Wtorek!");
                    break;
                case 3:
                    Console.WriteLine("Podany dzień to Środa!");
                    break;
                case 4:
                    Console.WriteLine("Podany dzień to Czwartek!");
                    break;
                case 5:
                    Console.WriteLine("Podany dzień to Piątek!");
                    break;
                case 6:
                    Console.WriteLine("Podany dzień to Sobota!");
                    break;
                case 7:
                    Console.WriteLine("Podany dzień to Niedziela!");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego numeru!");
                    break;

                
            }
        }
    }
}
