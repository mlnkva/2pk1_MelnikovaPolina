using System;

namespace pz_18._4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число больше единицы:");
                string n = Console.ReadLine();
                if (int.TryParse(n,out int number)&&(number>1))
                {
                    int summ = Summ(number);
                    Console.WriteLine($"Сумма чисел от 1 до {number} = {summ} ");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода:");
                }

            }
        }
        static int Summ(int n)
        {
            if (n==1)
            {
                return 1;
            }
            return n + Summ(n - 1);
        }
    }
}
