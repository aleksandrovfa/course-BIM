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
            double k = 4;
            double b = 2;
            Equation eq = new Equation(k, b);
            Console.WriteLine(eq.Root());
            Console.ReadKey();
        }
    }
    struct Equation
    {
        double K { get; set; }
        double B { get; set; }

        public Equation(double k, double b)
        {
            K = k;
            B = b;
        }

        public double Root()
        {
            double result = -B / K;
            return result;
        }
    }
}
