using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            int n = Convert.ToInt32(Console.ReadLine());
            int s, v;
            GetSandV(n, out s, out v);
            Console.WriteLine("Площадь поверхности куба = {0}", s);
            Console.WriteLine("Объем куба = {0}", v);
            Console.ReadKey();


        }
        static void GetSandV (int n, out int s, out int v)
        {
            v = n * n * n;
            s = n * n * 6; 
        }
    }
}
