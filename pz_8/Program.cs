using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                
                A[i] = rnd.Next(-10, 11);
                Console.WriteLine(A[i]);
                
            }
            Console.WriteLine("After reversing:");
            Array.Reverse(A, 0, 9);
            foreach (int k in A)
                Console.WriteLine(k);







        }
    }
}
