using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Homework
{
    class Task_3
    {
        public void Main3()
        {
            Console.WriteLine("Введите число от 20 до 69:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 19 || num > 69)
            {
                Console.WriteLine("Число не попадает в допустимый диапазон. Закрываюсь.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            int num1 = Convert.ToInt32(Math.Truncate((float)num / 10));
            int num2 = num % 10;
            string numString = null;
            switch (num1)
            {
                case 2:
                    {
                        numString += "двадцать";
                        break;
                    }
                case 3:
                    {
                        numString += "тридцать";
                        break;
                    }
                case 4:
                    {
                        numString += "сорок";
                        break;
                    }
                case 5:
                    {
                        numString += "пятдесят";
                        break;
                    }
                case 6:
                    {
                        numString += "шестьдесят";
                        break;
                    }
            }
            numString += " ";
            switch (num2)
            {
                case 1:
                    {
                        numString += "один";
                        break;
                    }
                case 2:
                    {
                        numString += "два";
                        break;
                    }
                case 3:
                    {
                        numString += "три";
                        break;
                    }
                case 4:
                    {
                        numString += "четыре";
                        break;
                    }
                case 5:
                    {
                        numString += "пять";
                        break;
                    }
                case 6:
                    {
                        numString += "шесть";
                        break;
                    }
                case 7:
                    {
                        numString += "семь";
                        break;
                    }
                case 8:
                    {
                        numString += "восемь";
                        break;
                    }
                case 9:
                    {
                        numString += "девять";
                        break;
                    }
            }
            numString += " ";
            if (num2 == 1)
            {
                numString += "год";

            }
            if (num2 == 0 ||
                num2 == 5 ||
                num2 == 6 ||
                num2 == 7 ||
                num2 == 8 ||
                num2 == 9)
            {
                numString += "лет";

            }
            if (num2 == 2 ||
                num2 == 3 ||
                num2 == 4)
            {
                numString += "года";
            }
            Console.WriteLine(numString);
            Console.ReadKey();
            return;
        }
    }
}
