using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "mouse", "cat", "child rat", "batting", "dogger", "I", "Steave Hophikns", "on", "children school primary", "institut imeni Presidenta Trampa", "BOY", "girl", "history", "science", "computer games", "player", "guse", "cow", "pistol" };
            string[][] massive = new string[5][];
            string[] massive2 = new string[5];
            string[] massive3 = new string[5];
            int n = 0;
            Random rnd = new Random();
            Random Rnd = new Random();
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < 5; i++)
            {
                massive[i] = new string[rnd.Next(3, 20)];
                for (int y = 0; y < massive[i].Length; y++)
                {
                    massive[i][y] = a[new Random().Next(0, a.Length)];
                }


                for (int c = 0; c < massive[i].Length; c++)
                {
                    Console.Write($"{massive[i][c]}" + ", ");
                    string s = massive[i][c];
                    char[] array = s.ToCharArray();

                    if (c == massive[i].Length - 1)
                    {
                        Console.WriteLine();
                        massive2[n] = massive[i][c];
                        n++;
                    }
                }
                Console.WriteLine();


            }
           

        }
    }
}
