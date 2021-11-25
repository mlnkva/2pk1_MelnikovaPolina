using System;

namespace pz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)//цикл для трёх треугольников
            {
                double a, h;//переменные для хранения значений основания и высоты
                while (true)//бесконечный цикл
                {
                    Console.WriteLine($"Введите значение основания {i} треугольника:");//вывод на экран сообщений для пользователя
                    string o = Console.ReadLine();//считывание с консоли пользовательского ввода и сохранение в переменную
                    if (double.TryParse(o,out a) && a>0)//условие проверки правильности ввода
                    {
                        break;//выход из бесконечного цикла, если вышеобозначенные условия соблюдены
                    }
                    else
                    {
                        Console.WriteLine("Знчение основания должно быть положительным числом");//сообщение пользователю, если условия не соблюдены
                    }
                }
                while (true)
                {
                    Console.WriteLine($"Введите значение высоты {i} треугольника:");
                    string o = Console.ReadLine();
                    if (double.TryParse(o, out h) && h > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Знчение высоты должно быть положительным числом");
                    }
                }
                double p = TriangleP(a, h);//вызов метода расчёта периметра и сохранение возвращаемого значения в переменную 
                Console.WriteLine($"Периметр {i} треугольника = {p}");//сообщение пользователю с результатом вычисления метода 
                double b = SideB(a, h);
                Console.WriteLine($"Боковая сторона {i} треугольника = {b}");
            }
          
        }
        
        static double TriangleP(double a, double h)//объявление метода 
        {
            double p = 2 * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2)) + 2 * a;//тело метода
            return p;//завершение работы метода, возврат значения
        }

        static double SideB(double a, double h)
        {
            return Math.Sqrt(Math.Pow((a / 2), 2) + Math.Pow(h, 2));//завершение работы метода, возврат значения
        }
    }
}
