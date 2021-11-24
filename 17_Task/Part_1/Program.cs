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
            string[] human1 = { "Петров", "Иван", "Сергеевич" };
            string[] human2 = { "Иванова", "Света", "Петровна" };

            Check<string> check1 = new Check<string>();
            check1.Name = human1;
            check1.Number = "125";
            check1.Balanse = 5000;
            check1.Print();

            Check<int> check2 = new Check<int>();
            check2.Name = human2;
            check2.Number = 125;
            check2.Balanse = 4500;
            check2.Print();

            Console.ReadKey();

        }

    }
    class Check<T>
    {
        T number;
        double balance;
        string firstname;
        string surname;
        string patronic;

        public T Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string[] Name
        {
            get
            {
                string[] arr = { firstname, surname, patronic };
                return arr;
            }
            set
            {
                if (value.Length == 3)
                {
                    firstname = value[0];
                    surname = value[1];
                    patronic = value[2]; 
                }
                else
                {
                    Console.WriteLine("Данные ФИО введены неверно");
                }
            }
        }
        public double Balanse
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным");
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("Номером {0}, ФИО: {1} {2} {3}, ,баланс: {4} ", number, firstname, surname, patronic , balance);
        }
    }
}
