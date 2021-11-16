using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task
{
    class Part_1
    {
        public void MainPart_1()
        {
            Console.WriteLine("Ввести целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (int i = 1; i <= 2 * N - 1; i=i+2)
            {
                n = n + i;
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
