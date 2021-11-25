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
            //string line = "({()})))";
            string line = "([]{})[]";

            Stack<char> stackSymbols = new Stack<char>();

            try
            {
                foreach (char i in line)
                {
                    
                    switch (i)
                    {
                        case '(':
                            stackSymbols.Push(')');
                            break;
                        case '{':
                            stackSymbols.Push('}');
                            break;
                        case '[':
                            stackSymbols.Push(']');
                            break;
                        default:
                            if (stackSymbols.Peek() == i)
                            {
                                stackSymbols.Pop();
                            }
                            break;
                    }
                }
                Console.WriteLine(line);
                if (stackSymbols.Count() == 0)
                {
                    Console.WriteLine("корректно  расставлены скобки");
                }
                else
                {
                    Console.Write("НЕкорректно  расставлены скобки");
                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(line);
                Console.WriteLine("Ошибка! " + ex.Message);
                Console.ReadKey();
            }

        }
    }
}
