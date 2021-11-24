using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //директория данного файла
            string dir = Environment.CurrentDirectory;
            
            //директория на 3 папки выше
            for (int i = 0; i < 3; i++)
            {
                dir = Directory.GetParent(dir).ToString();
            }
            //директория Products.json относительно папки 16 Занятие. 
            string path = "\\Part_1\\bin\\Debug\\Products.json";
            //Их сложение. Теоретически должно работать при нахождении папки 16 занятия в любом месте.
            path = dir + path;

            string json= File.ReadAllText(path);
            Products[] products= JsonSerializer.Deserialize<Products[]>(json);
            Console.WriteLine(products.ToString());
            Console.ReadKey();
            
        }
        class Products
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public double Coast { get; set; }

        }
    }
}
