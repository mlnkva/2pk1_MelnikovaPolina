using System;
using System.Linq;

namespace работа_с_текстом
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            while (true)
            {
                Console.WriteLine("Сколько строк вы хотите ввести?");
                string n = Console.ReadLine();
                if (int.TryParse(n, out count) && (count > 0))
                    break;
                else
                    Console.WriteLine("Количество строк должно быть целым положительным числом");
            }
            string[] stroki = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите {i + 1} строку");
                stroki[i] = Console.ReadLine();
            }
            Console.WriteLine("Вы ввели строки:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(stroki[i]);
            }
            string union_stroki = stroki[0];
            for (int i = 1; i < count; i++)
            {
                union_stroki = union_stroki + " " + stroki[i];
            }
            Console.WriteLine("Объединенная строка:");
            Console.WriteLine(union_stroki);
           var result = union_stroki.Split(" ").Distinct().ToArray();
            string result_string = "";
            for (int i = 0; i < result.Count(); i++)
            {
                result_string = result_string + " " + result[i];
            }
            result_string = result_string.Trim();
            Console.WriteLine("Итоговая строка:");
            Console.WriteLine(result_string);
        }
    }
}