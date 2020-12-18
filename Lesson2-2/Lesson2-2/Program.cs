using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой сейчас месяц?");
            string a = Console.ReadLine();
            int b= Convert.ToInt32(a);
            DateTime date = new DateTime(2020,b,1);
            Console.WriteLine(date.ToString("MMMM"));
            

        }
    }
}
