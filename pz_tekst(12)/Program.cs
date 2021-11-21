using System;
using System.IO;

class Program
{
    static void Main()
    {
        // считываем весь текст из первого и второго файлов
        string f1 = File.ReadAllText("C:\\File1.txt");
        string f2 = File.ReadAllText("C:\\File2.txt");
        // записываем текст из одного в другой файл
        File.WriteAllText(f1, "C:\\File2.txt");
        File.WriteAllText(f2, "C:\\File1.txt");
    }
}