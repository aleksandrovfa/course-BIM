using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Task<int> factorial1 = FactorialAsync(n);

            // проверка , правда не совсем понятно как она должна выполнятся.
            int factorial2 = Factorial(n,"Main");


            Console.WriteLine($"ФакториалAsync равен {factorial1.Result}");
            Console.WriteLine($"ФакториалMain равен {factorial2}");
            Console.WriteLine("Конец метода Main");
            Console.Read();
        }
        static int Factorial(int n, string where)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.WriteLine($"цикл {i} место запуска {where}") ;
                Thread.Sleep(500);
            }
            return result;
        }
        static async Task<int> FactorialAsync(int n)
        {
            Console.WriteLine("Начало метода FactorialAsync"); 
            int result = await Task.Run(() => Factorial(n,"Async"));           
            Console.WriteLine("Конец метода FactorialAsync");
            return result;
        }
    }
}
