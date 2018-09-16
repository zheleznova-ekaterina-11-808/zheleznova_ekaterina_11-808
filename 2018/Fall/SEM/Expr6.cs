using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Необходимо посчитать расстояние от точки до прямой, заданной двумя разными точками.
            Console.WriteLine("Koordinaty 1 tochki ");
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            Console.WriteLine("Koordinaty 2 tochki ");
            string x2 = Console.ReadLine();
            string y2 = Console.ReadLine();
            Console.WriteLine("Koordinaty 3 tochki");
            string x3 = Console.ReadLine();
            string y3 = Console.ReadLine();
            int x11 = int.Parse(x1);
            int y11 = int.Parse(y1);
            int x22 = int.Parse(x2);
            int y22 = int.Parse(y2);
            int x33 = int.Parse(x3);
            int y33 = int.Parse(y3);
            double a = Math.Sqrt((x11 - x22) * (x11 - x22) + (y11 - y22) * (y11 - y22));
            double b = Math.Sqrt((x11 - x33) * (x11 - x33) + (y11 - y33) * (y11 - y33));
            double c = Math.Sqrt((x33 - x22) * (x33 - x22) + (y33 - y22) * (y33 - y22));
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double h = (2 * S) / c;
            Console.WriteLine(h);
            Console.ReadLine();
        }
    }
}
