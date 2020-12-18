using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальну температуру:");
            string a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);
            Console.WriteLine("Введите максимальную температуру:");
            string b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);
            int c = (a1 + b1) / 2;
            Console.WriteLine($"Средняя температура ={c}");
        }
    }
}
