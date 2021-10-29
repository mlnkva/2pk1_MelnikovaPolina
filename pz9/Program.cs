using System;

namespace pz9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int minValue = 0;
            int maxValue = 50;
            int[,] A = new int[n, m];
            int min = 1;
            int max = minValue;
            Console.WriteLine("Элементы массива A:");
            Random rnd = new Random();
            int c;

            for (int i = 0; i < n ; i++)
                for (int j = 0; j < m; j++)
                {
                    c = rnd.Next(minValue, maxValue);
                    A[i, j] = c;
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(A [i, j] + "\t");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                min = A[0, i];
                for (int j = 0; j < n - 1; j++)
                    if (min > A[j + 1, i])
                        min = A[j + 1, i];
                if (min > max) max = min;
            }

            Console.WriteLine($"Максимум из наименьших элементов столбцов = {max}"); ;
        }
    }
}
                
            
        
    

