using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 25
В заданном массиве A(N) положительные элементы уменьшите вдвое, а
отрицательные элементы замените на значения их индексов.*/

namespace _3_1_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elems = new int[] { -8, -2, 8, -1, 6, 4, 8, -10 };

            for (int i = 0; i < elems.Length; i++)
            {
                if (elems[i] > 0)
                    elems[i] = elems[i] / 2;
                if (elems[i] < 0)
                    elems[i] = i;                
            }

            for (int i = 0; i < elems.Length; i++)
                Console.WriteLine($" i = {i}, {elems[i]}");
            
            Console.ReadKey();
        }
    }
}
