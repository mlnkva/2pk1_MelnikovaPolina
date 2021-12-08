using System;

namespace pz_18._1
{
    class Program
    {
        static double Progress(int n, double a, double d)
        {
            if (n < 1) return 0; //для отрицательных чисел
            else if (n == 1) return a; // случай, когда n=1
            return Progress(n - 1, a, d) + d; 
        }
        static void Main(string[] args)
        {
            double d = 0.1;
            double a = 10;
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Progress(n, a, d);
            Console.WriteLine(r);
        }
    }
}
