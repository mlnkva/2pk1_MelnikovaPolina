using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x;
            x = -2;
            do
            {
                y = (-2.4 * Math.Pow(x, 2) + 5 * x - 3);
                Console.WriteLine("{0} и {1}", x, y);
                x += 0.5;
            }
            while (x <= 2);
            Console.WriteLine();
           
            
            
        }
    }
}
