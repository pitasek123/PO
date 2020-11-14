using System;

namespace Zad3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0, a = 0, b = 0;
            double c = 0;
            while(menu != 4)
            {
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");

                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Podaj 1 liczbe: ");
                            a = Console.Read();
                            Console.WriteLine("Podaj 2 liczbe: ");
                            b = Console.Read();
                            c = a + b;
                            Console.WriteLine("Wynik to: {0} ", c);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Podaj 1 liczbe: ");
                            a = Console.Read();
                            Console.WriteLine("Podaj 2 liczbe: ");
                            b = Console.Read();
                            c = a - b;
                            Console.WriteLine("Wynik to: {0} ", c);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Podaj 1 liczbe: ");
                            a = Console.Read();
                            Console.WriteLine("Podaj 2 liczbe: ");
                            b = Console.Read();
                            c = a * b;
                            Console.WriteLine("Wynik to: {0} ", c);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Podaj 1 liczbe: ");
                            a = Console.Read();
                            Console.WriteLine("Podaj 2 liczbe: ");
                            b = Console.Read();
                            c = a / b;
                            Console.WriteLine("Wynik to: {0} ", c);
                            break;
                        }
                 
                    
                }
            }
        }
    }
}
