using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ConplexNumber
    {
        public double a;
        public string i;
        public double b;

        public ConplexNumber(double A, string I, double B)
        {
            a = A;
            i = I;
            b = B;
        }
        public void GetConplexNumber()
        {
            Console.WriteLine($"Действительная часть: {a}\nМнимая часть:{i}\nКоэффициент мнимой части:{b}");
        }
    }
}