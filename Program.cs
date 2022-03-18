using System;

namespace kalkulator_liczb_zespolonych
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Liczba pierwsza =  new Liczba("z1", 1,0);
            Console.WriteLine(pierwsza.ShowCoordinats());
            Liczba druga = new Liczba("z2", 0,2);
            Console.WriteLine(druga.ShowCoordinats());
            Console.WriteLine(pierwsza.Add(pierwsza, druga));
            Console.WriteLine(pierwsza.Subtract(pierwsza, druga));
            Console.WriteLine(pierwsza.Multiplicate(pierwsza, druga));
            Console.WriteLine(pierwsza.Divide(pierwsza, druga));
        }
    }
}
