using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product[] array = new Product[5];
            for (int i = 0; i < array.Length; i++)
                {
                    array[i] = InputProduct(i+1);
                }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder =JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };
            string json = JsonSerializer.Serialize<Product[]>(array,options);
            string path = "Products.json";
            File.WriteAllText(path, json);

            Console.WriteLine(json);
            Console.ReadKey();
        }
        static Product InputProduct(int number)
        {
            Product product = new Product();

            Console.WriteLine("Заполнение {0} товара. Введите код товара", number);
            product.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Заполнение {0} товара. Введите название товара", number);
            product.Name = Console.ReadLine();

            Console.WriteLine("Заполнение {0} товара. Цену товара", number);
            product.Coast = Convert.ToDouble(Console.ReadLine());

            return product;
        }
    }
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Coast { get; set; }

        public Product( int id, string name, double coast)
        {
            Id = id;
            Name = name;
            Coast = coast;
        }
        public Product()
        {

        }
    }
}
