using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("G:\\repos\\course BIM\\");
            foreach (var papka in di.GetDirectories())
            {
                if (papka.Exists)
                {
                    Console.WriteLine(papka.Name);
                    Console.WriteLine("    Cодержимое:   ");
                    foreach (var item in papka.GetDirectories())
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
