using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] strings = new string[2][];//создание ступенчатого массива (массив массивов). Изначальный массив состоит из двух вложенных массивов
            strings[0] = new string[9]
            {
                "сова",
                "ноутбук",
                "стул",
                "стол",
                "телевизор",
                "собака",
                "кот",
                "белка",
                "лев"
            };//инициализация первого вложенного массива
            Random random = new Random();//создание объекта класса Рандом
            int lenght = random.Next(7, 16);//генерация случайного числа в диапазоне от [7 - 16)
            strings[1] = new string[lenght];//объявление вторго вложенного массива
            Console.WriteLine($"Необходимо ввести {lenght} элементов массива");
            for (int i = 0; i < strings[1].Length; i++)//цикла для запроса пользователю элементов второго массива
            {
                Console.WriteLine($"Введите {i + 1} элемент массива:");
                strings[1][i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Итоговый массив:");
            for (int i = 0; i < strings.Length; i++)//цикл вывода ступенчатого массива
            {
                for (int s = 0; s < strings[i].Length; s++)
                {
                    Console.Write(strings[i][s] + "; ");
                }
                Console.WriteLine();
            }
            string[] LastElements = new string[2];//объявление одномерного массива из 2 элементов
            LastElements[0] = strings[0][strings[0].Length - 1];//инициализация элемента с индексом 0
            LastElements[1] = strings[1][strings[1].Length - 1];//инициализация элемента с индексом 1
            Console.WriteLine("Последние элементы строк:");
            foreach (var element in LastElements)//цикл для вывода на экран элементов массива
            {
                Console.WriteLine(element);
            }

            string[] MaxElements = new string[2];//объявление одномерного массива, состоящего из 2 элементов
            string tempMax = strings[0][0];//объявление переменной и её инициализация первым элементом вложенного массива
            int index1 = 0;//объявление и инициализация переменной для хранения индекса максимального элемента
            for (int i = 1; i < strings[0].Length; i++)//цикл для поиска максимального элемента в первом вложенном массиве
            {
                if (strings[0][i].Length>tempMax.Length)
                {
                    tempMax = strings[0][i];
                    index1 = i;
                }
            }
            MaxElements[0] = tempMax;//инициализация первого элемента массива максимальному элементу
            tempMax = strings[1][0];// инициализация переменной первым элементом второго вложенного массива
            int index2 = 0; //объявление и инициализация переменой для хранения индекса максимального элемента
            for (int i = 1; i < strings[1].Length; i++)//цикл для поиска максимального элемента во втором вложенном массиве
            {
                if (strings[1][i].Length > tempMax.Length)
                {
                    tempMax = strings[1][i];
                    index2 = i;
                }
            }
            MaxElements[1] = tempMax;//инициализация второго элемента массива максимальному элементу
            Console.WriteLine("Самые длинные элементы:");
            foreach (var element in MaxElements)//цикл для вывода элементов массива в консоль
            {
                Console.WriteLine(element);
            }

            string temp = strings[0][index1];
            strings[0][index1] = strings[0][0];
            strings[0][0] = temp;
            //обмен значений перменных
            temp = strings[1][index2];
            strings[1][index2] = strings[1][0];
            strings[1][0] = temp;
            //обмен значений перменных
            Console.WriteLine("Обновленный массив:");
            for (int i = 0; i < strings.Length; i++)//цикл для вывода элементов массива в консоль
            {
                for (int s = 0; s < strings[i].Length; s++)
                {
                    Console.Write(strings[i][s] + "; ");
                }
                Console.WriteLine();
            }
        }

    }
}
