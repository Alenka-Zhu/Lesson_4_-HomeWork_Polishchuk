using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравнить_количество_положительных_и_количество_отрицательных_введенных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел, окончанием которой служит число 0 ");

            int x = 0;

            int i = 1, k = 0, a;

            do

            {

                Console.Write("Введите" + i + "число - ");

                a = Convert.ToInt16(Console.ReadLine());

                if (a > 0)

                    k++;

                if (a < 0)

                    x ++;

                ++i;

            }

            while (a != 0);
            if (x >k)
            {
                Console.WriteLine("Количество отрицательных чисел больше колличества положительных ");
            }
            if (x < k)
            {
                Console.WriteLine("Количество положительных чисел больше количества отрицательных ");
            }
            else
            {
                Console.WriteLine("Количество положительных чисел равно количеству отрицательных ");
            }
            Console.ReadKey();
        }
    }
}
