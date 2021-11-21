using System;
using System.Linq;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите текст:");
            }
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            string s4 = Console.ReadLine();
            string s5 = Console.ReadLine();
            string s6 = Console.ReadLine();
            string s7 = Console.ReadLine();
            string[] values = new string[] { s1, s2, s3, s4, s5, s6, s7 };
            String s8 = String.Join(" ", values);
            string[] s = s8.Split(' ');
            

        }
    }
}
