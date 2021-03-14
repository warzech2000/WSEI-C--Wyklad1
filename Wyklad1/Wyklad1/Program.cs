using System;

namespace Wyklad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");

            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            //Console.WriteLine("Witaj" + imie + nazwisko + "!");
            //Console.WriteLine("Witaj {0} {1}!", nazwisko, imie);
            Console.WriteLine($"Witaj {imie} {nazwisko}!");
        }
    }
}
