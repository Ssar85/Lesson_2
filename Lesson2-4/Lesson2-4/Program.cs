using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите месяц");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Укажите среднюю температуру в этом месяце");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 0)
            {
                switch (a)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Дождливая зима");
                        break;
                     
                }
            }
        }
    }
}
