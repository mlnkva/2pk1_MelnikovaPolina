using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "Тестовая строка 39, нужно извлечь все 8 или мб 2. числа";
            string numbers = String.Empty;

            for (int i = 0; i < testStr.Length; i++)
            {
                if (char.IsDigit(testStr[i]) || char.IsWhiteSpace(testStr[i]))
                {
                    numbers += testStr[i];
                }
            }

            string[] nums = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string num in nums)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
