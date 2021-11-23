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
            #region ArithProgression

            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("        Арифметической прогрессией");
            Console.WriteLine("Установка первого значения на 6");
            arithProgression.setStart(6);

            Console.WriteLine("Получение следующих 5 элементов в цикле:");
            for (int i = 0; i < 5; i++)
            {
                int item = arithProgression.getNext();
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Сброс на начальные значение ");
            arithProgression.reset();
            Console.WriteLine("Значение после сброса  = {0}",arithProgression.Now);

            #endregion



            #region GeomProgression

            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("        Геометрическая прогрессией");
            Console.WriteLine("Установка первого значения на 6");
            geomProgression.setStart(6);

            Console.WriteLine("Получение следующих 5 элементов в цикле:");
            for (int i = 0; i < 5; i++)
            {
                int item = geomProgression.getNext();
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Сброс на начальные значение ");
            geomProgression.reset();
            Console.Write("Значение после сброса  = {0}", geomProgression.Now);

            #endregion


            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();

    }
    class ArithProgression : ISeries
    {
        //начальное значение
        private int a = 0;
        //шаг прогрессии
        private int d = 2;
        //Значение в данный момент
        public int Now { get; set; }
        public int getNext()
        {
            Now = Now + d;
            return Now;
        }

        public void reset()
        {
            Now = a;
        }

        public void setStart(int x)
        {
            Now = x;
            a = x;
        }
    }
    class GeomProgression : ISeries
    {

        //начальное значение
        private int a = 0;
        //знаменатель прогрессии
        private int d = 2;
        //Значение в данный момент
        public int Now { get; set; }
        public int getNext()
        {
            Now = Now * d;
            return Now;
        }

        public void reset()
        {
            Now = a;
        }

        public void setStart(int x)
        {
            Now = x;
            a = x;
        }
    }
}
