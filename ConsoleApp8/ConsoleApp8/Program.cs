using ConsoleApp;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ConplexNumber c = new ConplexNumber(5, "i", 4);
            c.GetConplexNumber();
            Console.WriteLine();
            ConplexNumber c1 = new ConplexNumber(1, "i", 3);
            c1.GetConplexNumber();
            Console.WriteLine();
            ConplexNumber c2 = new ConplexNumber(7, "i", 8);
            c2.GetConplexNumber();
            Console.WriteLine();
            ConplexNumber c3 = new ConplexNumber(2, "i", 9);
            c3.GetConplexNumber();
            Console.WriteLine();

        }
    }
}