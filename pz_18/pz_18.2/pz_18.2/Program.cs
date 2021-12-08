using System;

namespace pz_18._2
{
    class Program
    {
        static double Progress(int n, double b, double q)
        {
            if (n == 1)
                return b;
            else
                return Progress(n - 1, b, q) * q;
        }
        static void Main(string[] args)
        {
            double q = 0.15;
            double b = 14;
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Progress(n, b, q);
            Console.WriteLine(r);
        }
    }
}