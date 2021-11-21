using System;
using System.IO;
using System.Text;
namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = File.ReadAllText(@"C:\Users\admin\Desktop\pz\f1.txt", Encoding.UTF8);
            string f2 = File.ReadAllText(@"C:\Users\admin\Desktop\pz\f2.txt", Encoding.UTF8);
            File.WriteAllText (@"C:\Users\admin\Desktop\pz\f.txt", f1, Encoding.UTF8);
            File.WriteAllText(@"C:\Users\admin\Desktop\pz\f2.txt",
            File.ReadAllText(@"C:\Users\admin\Desktop\pz\f.txt", Encoding.UTF8),
            Encoding.UTF8);
            File.WriteAllText(@"C:\Users\admin\Desktop\pz\f1.txt", f2, Encoding.UTF8);

        }


    }
}