using System;

namespace pz_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string s1 = Console.ReadLine();//считывание значения с консоли и сохранение в пременную
            Console.WriteLine("Введите вторую строку:");
            string s2 = Console.ReadLine();
            bool isCompare = CompareStrings(s1, s2);//вызов метода и результаты сохранения возвращаемого значения в переменную
            if (isCompare)//проверка результата работы метода
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки неравны");
            }
        }

        static bool CompareStrings(string s1, string s2)//объявление метода
        {
            //тело метода
            if (s1.Length!=s2.Length)
            {
                return false;//завершение работы метода и возврат значения
            }
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i]!=s2[i])
                {
                    return false;//завершение работы метода и возврат значения
                }
            }
            return true;//завершение работы метода и возврат значения
        }
    }
}
