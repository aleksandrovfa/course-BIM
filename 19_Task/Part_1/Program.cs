using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string CPUtype { get; set; }
        public int CPUfrequency { get; set; }
        public int RAMsize { get; set; }
        public int HDDsize { get; set; }
        public int VideoCapacity { get; set; }
        public int Cost { get; set; }
        public int Stock { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Id = 1, Brand = "Sun", CPUtype= "Intel Core i3", CPUfrequency=2500, RAMsize = 2, HDDsize=512, VideoCapacity = 1, Cost = 51300 , Stock = 3},
                new Computer(){Id = 2, Brand = "ASUS", CPUtype= "Intel Core i5", CPUfrequency=3500, RAMsize = 4, HDDsize=1024, VideoCapacity = 2, Cost = 78350 , Stock = 6},
                new Computer(){Id = 3, Brand = "MSI", CPUtype= "Intel Core i7", CPUfrequency=4100, RAMsize = 8, HDDsize=256, VideoCapacity = 4, Cost = 140000 , Stock = 7},
                new Computer(){Id = 4, Brand = "Hewlett-Packard", CPUtype= "Intel Core i3", CPUfrequency=2500, RAMsize = 2, HDDsize=512, VideoCapacity = 1, Cost = 68540 , Stock = 3},
                new Computer(){Id = 5, Brand = "MSI", CPUtype= "Intel Core i5", CPUfrequency=3500, RAMsize = 4, HDDsize=1024, VideoCapacity = 2, Cost = 78350 , Stock = 4},
                new Computer(){Id = 6, Brand = "Dell", CPUtype= "Intel Core i7", CPUfrequency=4100, RAMsize = 8, HDDsize=256, VideoCapacity = 4, Cost = 140000 , Stock = 7},
                new Computer(){Id = 7, Brand = "Sun", CPUtype= "AMD Ryzen PRO", CPUfrequency=2500, RAMsize = 2, HDDsize=512, VideoCapacity = 1, Cost = 58064 , Stock = 15},
                new Computer(){Id = 8, Brand = "ASUS", CPUtype= "AMD Athlon PRO", CPUfrequency=3500, RAMsize = 4, HDDsize=1024, VideoCapacity = 2, Cost = 78350 , Stock = 6},
                new Computer(){Id = 9, Brand = "MSI", CPUtype= "AMD Radeon PRO", CPUfrequency=4100, RAMsize = 8, HDDsize=256, VideoCapacity = 4, Cost = 155000 , Stock = 7},
                new Computer(){Id = 10, Brand = "Hewlett-Packard", CPUtype= "Intel Core i3", CPUfrequency=2500, RAMsize = 4, HDDsize=512, VideoCapacity = 1, Cost = 68540 , Stock = 3},
                new Computer(){Id = 11, Brand = "Dell", CPUtype= "Intel Core i5", CPUfrequency=3500, RAMsize = 4, HDDsize=1024, VideoCapacity = 4, Cost = 78350 , Stock = 35},
                new Computer(){Id = 12, Brand = "Dell", CPUtype= "Intel Core i7", CPUfrequency=3500, RAMsize = 8, HDDsize=256, VideoCapacity = 4, Cost = 140000 , Stock = 62},
            };


            #region 1 задание
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Введите название процессора для поиска:");
            string CPU = Console.ReadLine();

            List<Computer> ComputersCPU = listComputer
                .Where(d => d.CPUtype == CPU)
                .ToList();

            Print(ComputersCPU);
            Console.WriteLine("--------------------------------------");
            #endregion

            #region 2 задание
            Console.WriteLine("Введите объем ОЗУ для поиска:");
            int RAM = Convert.ToInt32(Console.ReadLine());

            List<Computer> ComputersRAM = listComputer
                .Where(d => d.RAMsize >= RAM)
                .ToList();

            Print(ComputersRAM);
            Console.WriteLine("--------------------------------------");
            #endregion

            #region 3 задание
            Console.WriteLine("Весь список отсортированные по увеличение стоитмости.");
            List<Computer> ComputersSortCoast = listComputer
                .OrderBy(d => d.Cost)
                .ToList();
            Print(ComputersSortCoast);
            Console.WriteLine("--------------------------------------");
            #endregion

            #region 4 задание
            Console.WriteLine("Весь список сгруппированный по типу процессора.");
            foreach (var item in listComputer
                .GroupBy(p => p.CPUtype)
                .ToList())
            {
                Console.WriteLine($"{item.Key}");
                foreach (var i in item)
                {
                    Console.WriteLine($" Id:{i.Id} Brand:{i.Brand} CPU:{i.CPUtype} frequency:{i.CPUfrequency} RAM:{i.RAMsize} HDD:{i.HDDsize} Video:{i.VideoCapacity} Coast:{i.Cost} Stock:{i.Stock}");
                }
            }
            Console.WriteLine("--------------------------------------");
            #endregion

            #region 5 задание
            Console.WriteLine("самый дорогой и самый дешевый товар:.");
            int MaxCost = listComputer.Max(p => p.Cost);
            int MinCost = listComputer.Min(p => p.Cost);
            List<Computer> ComputersMaxMin = listComputer
                .Where(d => d.Cost == MaxCost || d.Cost == MinCost)
                .ToList();
            Print(ComputersMaxMin);
            Console.WriteLine("--------------------------------------");
            #endregion

            #region 6 задание
            Console.WriteLine("есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            List<Computer> ComputersStock = listComputer
                .Where(d => d.Stock >=30)
                .ToList();
            if (ComputersStock.Count>0)
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
            #endregion

            Console.ReadKey();
        }
        public static void Print(List<Computer> list)
        {
            if (list.Count > 0)
            {
                foreach (Computer i in list)
                    Console.WriteLine($" Id:{i.Id} Brand:{i.Brand} CPU:{i.CPUtype} frequency:{i.CPUfrequency} RAM:{i.RAMsize} HDD:{i.HDDsize} Video:{i.VideoCapacity} Coast:{i.Cost} Stock:{i.Stock}");
            }
            else
                Console.WriteLine("Ничего не найдено");

        }
    }
}
