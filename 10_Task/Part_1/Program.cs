using System;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы, минуты, секунды через пробел");
            string line = Console.ReadLine();
            string[] lineSplit = line.Split();
            int[] lineInt = new int[lineSplit.Length];
            try
            {
                for (int i = 0; i < lineSplit.Length; i++)
                {
                    lineInt[i] = Convert.ToInt32(lineSplit[i]);
                }
                Angle angle1 = new Angle(lineInt[0], lineInt[1], lineInt[2]);
                Console.WriteLine("Значение угла в радианах: {0}", angle1.ToRadians());
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
    class Angle
    {
        private int gradus = 0;
        private int min = 0;
        private int sec = 0;

        public int Gragus
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    gradus = value;
                    Console.WriteLine("Градусы заданы значением: {0}", gradus);
                }
                else
                {
                    Console.WriteLine("Ошибка! Градусы задается в диапазоне от 0 до 359, значение по умол. = {0}", gradus);
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                    Console.WriteLine("Минуты заданы значением: {0}", min);
                }
                else
                {
                    Console.WriteLine("Ошибка! Минуты задается от 0 до 59, значение по умол. = {0}", min);
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                    Console.WriteLine("Секунды заданы значением: {0}",sec);
                }
                else
                {
                    Console.WriteLine("Ошибка! Секунды задается от 0 до 59, значение по умол. = {0}", sec);
                }
            }
            get
            {
                return sec;
            }
        }


        public Angle(int gradus, int min, int sec)
        {
            Console.WriteLine("Вход в конструктор класса Angle");
            Gragus = gradus;
            Min = min;
            Sec = sec;
            Console.WriteLine("Выход из конструктор класса Angle");
        }

        public double ToRadians()
        {
            double gradusDecimal = Convert.ToDouble(gradus) + (Convert.ToDouble(min) + Convert.ToDouble(sec) / 60) / 60;
            double radians = gradusDecimal* Math.PI/180;
            return radians;
        }

    }
}
