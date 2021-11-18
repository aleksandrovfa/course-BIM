using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 7;
            float summArray = 0;
            int[] array = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine("Введите {0} элемент массива", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in array)
            {
                summArray += item;
            }
            float avgArray = summArray / sizeArray;
            Console.WriteLine("Среднее арифметическое массива равно = {0,2}",avgArray);
            Console.ReadKey();
        }

    }
}
