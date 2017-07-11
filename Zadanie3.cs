using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] {1,17,23,5,10,6,4,7,17,4};

            Console.Write("Изначальный массив:\n");
            foreach (int i in a)
                Console.Write("{0} ", i);

            Console.Write("\n");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.Write("Результирующий массив:\n");
            foreach (int i in a)
                Console.Write("{0} ", i);

            Console.ReadKey();
        }
    }
}
