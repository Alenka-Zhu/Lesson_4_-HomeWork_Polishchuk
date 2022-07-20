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
            int sum1 = 0;
            int sum2 = 0;   
            int sum = 0;
            while (c1<=a)
                {
                c1 += c;
                sum1++;
                }
            while (c2<=b)
                {
                c2 += c;
                sum2++;
                sum= sum1 + sum2;
                }
            Console.WriteLine(sum);
            Console.ReadKey();  
        }
    }
}
