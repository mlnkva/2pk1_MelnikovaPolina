using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");

            for (int i = -25; i <= 25; i += 25)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine("Задание 3");
            int n = 0;
            int m = 0;
            for (n = 0; n <4; n++)
            {
                for (m = 0; m < 7; m++)
                {
                    Console.Write("#");

                }

                Console.WriteLine();
            }

          
            Console.WriteLine("Задание 4");

            int a;
            for (a = 0; a <= 100; a++)
            {
                if (a == 0) continue;
                if ((a % 2) != 0) continue;
                Console.WriteLine(a + " ");
            }


            Console.WriteLine("Задание 2");
                int b;
                b = 0;
                char simvol = 'P';
                while (b < 5)
                {
                    b += 1;
                    Console.Write(simvol + " ");
                    simvol++;
                }
            





        }
        }
    }










    