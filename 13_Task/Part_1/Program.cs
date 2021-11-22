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
            Building building = new Building("Пушкина 20", 10, -2, 2);
            building.Print();
            MultiBuilding multiBuilding = new MultiBuilding("Крупской 20", 45, 35, 22, 2);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    public class Building
    {
        public string Adress { get; set; }
        double length;
        double width;
        double height;
        public double Length 
        {
            set
            {
                if (value>0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина здание должна быть больше  0");
                }
            } 
            get
            {
                return length;
            } 
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здание должна быть больше 0");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Длина здание должна быть больше 0");
                }
            }
            get
            {
                return height;
            }
        }

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public virtual void  Print()
        {
            Console.WriteLine("Адресс здания: {0}", Adress);
            Console.WriteLine("Длина здания {0}", Length);
            Console.WriteLine("Ширина здания {0}", Width);
            Console.WriteLine("Высота здания {0}", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        int level;
        public int Level
        {
            set
            {
                if (value > 0)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Этажность здание должна быть больше 0");
                }
            }
            get
            {
                return level;
            }
        }
        public MultiBuilding(string adress, double length, double width, double height, int level)
                :base(adress,length,width,height)
        {
            Level = level;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", Level);
        }

    }
}
