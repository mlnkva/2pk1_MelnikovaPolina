using System;

namespace pz_18._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 87;
            int b = -87;
            Numbers(a, b);
        }

        static void Numbers(int a, int b)
        {
            Console.WriteLine(b);
           if (a>b)
                {
                Numbers(a, b + 1);
                }
                
        }
    }
}
