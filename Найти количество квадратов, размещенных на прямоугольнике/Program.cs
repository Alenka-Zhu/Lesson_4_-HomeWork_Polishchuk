using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Найти_количество_квадратов__размещенных_на_прямоугольнике
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника А и В и сторону квадрата С");
            int a = Convert.ToByte(Console.ReadLine());
            int b = Convert.ToByte(Console.ReadLine());
            int c = Convert.ToByte(Console.ReadLine());
            int c1 = c;
            int c2 = c;
            int sum = c1 + c2;
            while (a>c1)
                {
                c1 += c1;
                }
            while (b > c2)
                {
                c2 += c2;
                }
            Console.WriteLine(sum);
            Console.ReadKey();  
        }
    }
}
