using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Homework
{
    class Task_1
    {
        public void Main1()
        {
            // Ввод данных трех точек
            List<int> a = Input("1");
            List<int> b = Input("2");
            List<int> c = Input("3");
            List<int> d = null;

            //Проверка лежат ли точки на прямой, которая параллельна координатным осям
            bool control_ab = Control(a, b);
            bool control_bc = Control(b, c);
            bool control_ac = Control(a, c);

            //Проверка образуется ли прямоугольник
            // Для этого 2 из 3 control должны быть true
            bool rectangle;
            if ( (control_ab && control_bc && !control_ac) || 
                 (control_ac && control_ab && !control_bc) || 
                 (control_bc && control_ac && !control_ab))
            {
                rectangle = true;
            }
            else
            {
                rectangle = false;
            }


            //Нахождение координаты 4 точки при удовлетвория условия прямоугольника
            if (rectangle)
            {
                if (!control_ab)
                {
                    d = CoordD(a, b, c);
                }
                if (!control_bc)
                {
                    d = CoordD(b, c, a);
                }
                if (!control_ac)
                {
                    d = CoordD(a, c, b);
                }
                Console.WriteLine("Координаты четвертой точки: {0} {1}", d[0], d[1]);
            }
            else
            {
                Console.WriteLine("Прямоугольник со сторонами, которые параллельны координатным осям, не образуется. Закрываюсь");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.ReadKey();
            return;
        }

        static List<int> Input(string Text)
        //Метод который возвращает координаты точек.
        {
            Console.WriteLine("Введите координаты {0} точки через пробел: ",Text);
            string coordStr = Console.ReadLine();
            string[] temp = coordStr.Split(new Char[] { ' ' });
            // В этом методе задумывалось реализовать различные проверки на ошибки, с try catch не особо справляюсь, поэтому пока так
            if (temp.Length >2)
            {
                Console.WriteLine("Ошибка: Введено больше переменных, закрываюсь");
                Console.ReadKey();
                Environment.Exit(0);
            }
            List<int> coordInt = new List<int>();
            foreach (string item in temp)
            {
                int num = Convert.ToInt32(item);
                coordInt.Add(num);
            }
            return coordInt;
        }


        static bool Control (List<int> a, List<int> b)
        //Метод для определиния параллельности
        //Параллельность потверждается при совпадении координаты X или Y
        {
            if (a[0] == b[0] || a[1] == b[1])
            {
                return true;
            }
            return false;
        }

        static List<int> CoordD(List<int> a , List<int> c, List<int> b)
         //Метод для нахождения координаты 4 точки.
         //Сначало находится середина между диагональных точек.Далее с помощью третьей точки находится 4.
        {
            List<int> coordD = new List<int>();
            float ox = ((float)a[0] + (float)c[0]) / 2;
            float oy = ((float)a[1] + (float)c[1]) / 2;
            float dx = 2 * ox - (float)b[0];
            float dy = 2 * oy - (float)b[1];
            coordD.Add(Convert.ToInt32(dx));
            coordD.Add(Convert.ToInt32(dy));
            return coordD;
        }

    }
}
