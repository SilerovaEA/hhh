using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipluynumb
{
    class Program
    {
       // Найти произведение всех целых четных чисел, делящихся на 4 и принадлежащих интервалу[n_min, n_max].
        static void Main(string[] args)
        {
          int  p = 1;
            Console.Write("введите  n_min=");
            int n_min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите n_max=");
            double n_max = Convert.ToInt32(Console.ReadLine());
            for (int i=n_min; i <= n_max; i++)
            {
                if (i % 4 == 0)
                {
                    p *= i;
                }
            }
            if (p > 1)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("there are no this number");
            }
            Console.ReadKey();
        }
    }
}
